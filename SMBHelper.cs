using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon;
using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;
using System.Data;

namespace Syscon.IndirectCostAllocation
{
    public class SMBHelper
    {
        /// <summary>
        /// Returns the dataset version of currently connected database.
        /// The database name is with which the connection is made to.
        /// </summary>
        /// <returns></returns>
        public static decimal GetDataSetVersion()
        {
            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                decimal retVal = -1;

                string strSql = "SELECT VAL(vernum) FROM cmpany WHERE RECNO() = 1";
                try
                {
                    retVal = con.GetScalar<decimal>(strSql);
                }
                catch
                {
                    retVal = -1;
                    return retVal;
                }

                return retVal;
            }
        }

        /// <summary>
        /// *	Returns the requested GL Set up info the passed data set - 
        ///   Valid for version 19.x and greater
        ///*	Error Codes
        ///*	-1		S100C Data Directory reference invalid
        ///PARAMETERS mbdir, pName
        ///* Valid pNames
        ///*	CURRENTFISCALYEAR	- Returns the current fiscal year
        ///*	CURRENTPERIOD		- Returns the current accounting period that is open
        ///*	FISCALYEAREND		- Returns the fiscal year end
        ///*	ARCONTROL			- Returns the AR Control Account
        ///*	ARTAX				- Returns the AR Tax Liability Account
        ///*	SRCONTROL			- Returns the SR Control Account
        ///*	APCONTROL			- Returns the AP Control Account
        ///*	FIELDNAME			- Returns the result of evaluationg lgrset.fieldname */
        /// </summary>
        /// <returns></returns>
        public static int GetDataSetGLInfo(string pName)
        {
            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                int retVal = 0;
                string sqlStr = string.Empty;
                pName = pName.Trim();

                try
                {
                    switch (pName)
                    {
                        case "CURRENTFISCALYEAR":
                            sqlStr = "SELECT YEAR(fscyrd) FROM lgrset WHERE RECNO() = 1";
                            break;
                        case "CURRENTPERIOD":
                            sqlStr = "SELECT curprd FROM lgrset WHERE RECNO() = 1";
                            break;
                        case "FISCALYEAREND":
                            sqlStr = "SELECT fscyrd FROM lgrset WHERE RECNO() = 1";
                            break;
                        case "ARCONTROL":
                            sqlStr = "SELECT ded_ar FROM lgrset WHERE RECNO() = 1";
                            break;
                        case "ARTAX":
                            sqlStr = "SELECT ar_tax FROM lgrset WHERE RECNO() = 1";
                            break;
                        case "SRCONTROL":
                            sqlStr = "SELECT ded_sr FROM lgrset WHERE RECNO() = 1";
                            break;
                        case "APCONTROL":
                            sqlStr = "SELECT ded_ap FROM lgrset WHERE RECNO() = 1";
                            break;
                        default: 				//&& Try to evaluate the field name directly
                            sqlStr = string.Format("SELECT {0} FROM lgrset WHERE RECNO() = 1", pName);
                            break;
                    }
                    //IF ISNULL(laTemp(1,1))
                    //    RtnVal = -2
                    //ELSE
                    //    RtnVal = laTemp(1,1)
                    //ENDIF 
                    retVal = con.GetScalar<int>(sqlStr);
                }
                catch (Exception ex)
                {
                    retVal = -1;
                    return retVal;
                }

                return retVal;
            }
        }

        public int GetDataSetPostingPeriods(out DataTable dtOut)
        {
            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                int retVal = -1;

                try
                {
                    dtOut = con.GetDataTable("", "SELECT distinct postyr, actprd FROM lgrbal ORDER BY postyr, actprd");
                    retVal = (dtOut.Rows.Count == 0) ? -2 : dtOut.Rows.Count;
                }
                catch (Exception)
                {
                    retVal = -1;
                    dtOut = null;
                }

                return retVal;
            }
        }

//        *--------------------------------------------------------------------*
//FUNCTION getDataSetPostingPeriods
//* Jan 2014 LAW
//*	Returns the valid posting periods passed data set - Valid for version 19.x and greater
//* 	The first fiscal year in the returned array (lowest year number) must be considered 
//* 	an archive year and cannot be posted to
//*	Error Codes
//*	-1		S100C Data Directory reference invalid
//PARAMETERS mbdir, parray


//LOCAL RtnVal, lnLastSelect, lcFileName, llOpenedCompanyFile, loError

//RtnVal = 0
//llOpenedCompanyFile = .f.
//lcFileName = mbdir + "lgrbal" 
//lnLastSelect = 0

//lnLastSelect = SELECT()

//* Open the cmpany data file 
//IF SELECT('lgrbal') <= 0
//    TRY 
//        USE (lcFileName) SHARED IN 0
//        llOpenedCompanyFile = .t.
//    CATCH TO loError
//        RtnVal = -1
//    ENDTRY 
//ENDIF 

//IF RtnVal = 0		&& Opened Cmpany and can proceed
//    SELECT distinct postyr, actprd ;
//        FROM lgrbal INTO ARRAY parray ;
//        ORDER BY postyr, actprd
//    IF ISNULL(parray(1,1))
//        RtnVal = -2
//    ELSE
//        RtnVal = ALEN(pArray)
//    ENDIF 
//ENDIF 

	

//* Clean up
//IF llOpenedCompanyFile
//    USE IN ('lgrbal')
//ENDIF 
//* Return the current work area to the last used 
//IF lnLastSelect > 0
//    SELECT(lnLastSelect)
//ENDIF 

//RETURN (RtnVal)

        public static int GetDataSetCurrentFY()
        {
            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                int retVal = -1;

                try
                {
                    int year = con.GetScalar<int>("SELECT YEAR(fscyrd) FROM lgrset WHERE RECNO() = 1");
                    retVal = (year == 0) ? -2 : year;
                }
                catch (Exception ex)
                {
                    retVal = -1;
                }

                return retVal;
            }
        }

//        *--------------------------------------------------------------------*
//FUNCTION getDataSetCurrentFY
//* Jan 2014 LAW
//*	Returns the current fiscal of the passed data set - Valid for version 19.x and greater
//*	Error Codes
//*	-1		S100C Data Directory reference invalid
//PARAMETERS mbdir


//LOCAL RtnVal, lnLastSelect, lcFileName, llOpenedCompanyFile, loError
//LOCAL ARRAY laTemp(1,1)

//RtnVal = 0
//llOpenedCompanyFile = .f.
//lcFileName = mbdir + "lgrset" 
//lnLastSelect = 0

//lnLastSelect = SELECT()

//* Open the cmpany data file 
//IF SELECT('lgrset') <= 0
//    TRY 
//        USE (lcFileName) SHARED IN 0
//        llOpenedCompanyFile = .t.
//    CATCH TO loError
//        RtnVal = -1
//    ENDTRY 
//ENDIF 

//IF RtnVal = 0		&& Opened Cmpany and can proceed
//    SELECT YEAR(fscyrd) FROM lgrset WHERE RECNO() = 1 INTO ARRAY laTemp
//    IF ISNULL(laTemp(1,1))
//        RtnVal = -2
//    ELSE
//        RtnVal = laTemp(1,1)
//    ENDIF 
//ENDIF 

	

//* Clean up
//IF llOpenedCompanyFile
//    USE IN ('lgrset')
//ENDIF 
//* Return the current work area to the last used 
//IF lnLastSelect > 0
//    SELECT(lnLastSelect)
//ENDIF 

//RETURN (RtnVal)

    }
}
