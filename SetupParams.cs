using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syscon.IndirectCostAllocation
{

    /// <summary>
    /// The setup parameters for this application
    /// </summary>
    public class SetupParams
    {
        public event EventHandler SMBDirChanged;

        /// <summary>
        /// Ctor
        /// </summary>
        public SetupParams()
        {

        }

        #region Properties

        private string _smbDir;
        public string MBDir
        {
            get { return _smbDir; }
            set
            {
                _smbDir = value;
                FireSMBDirChangedEvent();
            }
        }

        public string CompanyName
        {
            get;
            set;
        }

        public bool CreateReversalEntry
        {
            get;
            set;
        }

        public bool CopyPercentToJobcst
        {
            get;
            set;
        }
        #endregion

        private void FireSMBDirChangedEvent()
        {
            if (SMBDirChanged != null)
                SMBDirChanged(this, EventArgs.Empty);
        }
    }
}
