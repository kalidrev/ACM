using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        public enum EntityStateOption
        {
            Active,
            Deleted
        }

        #region Fields & Properties
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid
        {
            get
            {
                return Validate();
            }
        }

        #endregion

        #region Methods

        public abstract bool Validate();

        #endregion
    }
}
