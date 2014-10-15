using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysconCommon.Algebras.DataTables;

namespace Syscon.IndirectCostAllocation
{
    /// <summary>
    /// 
    /// </summary>
    public class ICAPDataModel
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public ICAPDataModel()
        {

        }

        #region Properties

        [ColumnOrder(10)]
        public int RecNum
        {
            get;
            set;
        }

        [ColumnOrder(20)]
        public string ShtNme
        {
            get;
            set;
        }

        [ColumnOrder(30)]
        public string LngNme
        {
            get;
            set;
        }

        [ColumnOrder(40)]
        public string ActNme
        {
            get;
            set;
        }

        [ColumnOrder(50)]
        public string CtrAct
        {
            get;
            set;
        }

        [ColumnOrder(60)]
        public string ActTyp
        {
            get;
            set;
        }

        [ColumnOrder(70)]
        public decimal PerAmt
        {
            get;
            set;
        }

        [ColumnOrder(80)]
        public bool UseAct
        {
            get;
            set;
        }

        #endregion
    }
}
