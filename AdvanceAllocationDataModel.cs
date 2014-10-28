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
    public class AdvanceAllocationDataModel
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public AdvanceAllocationDataModel()
        {

        }

        #region Properties

        [ColumnOrder(10)]
        public int jobNme
        {
            get;
            set;
        }

        [ColumnOrder(20)]
        public string acosts
        {
            get;
            set;
        }

        [ColumnOrder(30)]
        public string cstper
        {
            get;
            set;
        }

        [ColumnOrder(40)]
        public string ahours
        {
            get;
            set;
        }

        [ColumnOrder(50)]
        public string hrsper
        {
            get;
            set;
        }

        [ColumnOrder(60)]
        public string revenue
        {
            get;
            set;
        }

        [ColumnOrder(70)]
        public decimal revper
        {
            get;
            set;
        }

        [ColumnOrder(80)]
        public bool s_origall
        {
            get;
            set;
        }

        [ColumnOrder(90)]
        public bool s_edited
        {
            get;
            set;
        }

        [ColumnOrder(100)]
        public bool o_origall
        {
            get;
            set;
        }

        [ColumnOrder(110)]
        public bool o_edited
        {
            get;
            set;
        }

        [ColumnOrder(120)]
        public bool a_origall
        {
            get;
            set;
        }

        [ColumnOrder(130)]
        public bool a_edited
        {
            get;
            set;
        }

        #endregion
    }
}
