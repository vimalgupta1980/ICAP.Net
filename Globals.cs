using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syscon.IndirectCostAllocation
{
    public class Globals
    {
        private static Globals _instance;

        /// <summary>
        /// Private constructor
        /// </summary>
        private Globals()
        {
        
        }

        /// <summary>
        /// Get the singleton instance
        /// </summary>
        /// <returns></returns>
        public static Globals Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Globals();
                }
                return _instance;
            }
        }

        public decimal DataSetVersion
        {
            get;
            set;
        }

        /// <summary>
        /// The fiscal year where allocations are being applied
        /// </summary>
        public int ActiveFiscalYear
        {
            get;
            set;
        }

        /// <summary>
        /// Current Fiscal Year
        /// </summary>
        public int CurrentFiscalYear
        {
            get;
            set;
        }

        /// <summary>
        /// Current archive year in the data set
        /// </summary>
        public int ArchiveFiscalYear
        {
            get;
            set;
        }

        /// <summary>
        /// Last fiscal year with posting periods
        /// </summary>
        public int LastFiscalYear
        {
            get;
            set;
        }

        public int PeriodBeginning
        {
            get;
            set;
        }

        public int PeriodEnd
        {
            get;
            set;
        }

        public List<string> PostingPeriods
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }

        public string CostType
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Supers
        {
            get;
            set;
        }

        public AllocationMethod AllocationMethod
        {
            get;
            set;
        }

        public bool UseDept
        {
            get;
            set;
        }

        public bool HideZeroAccts
        {
            get;
            set;
        }
    }
}
