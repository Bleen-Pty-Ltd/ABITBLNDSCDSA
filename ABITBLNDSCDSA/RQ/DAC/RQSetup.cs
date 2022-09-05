using PX.Data;

namespace PX.Objects.RQ
{
    public class RQSetupExt : PXCacheExtension<RQSetup>
  {
        #region UsrLockStockDescription
        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)] 
        [PXUIField(DisplayName = "Lock Stock Description")]
        public virtual bool? UsrLockStockDescription{get;set;}
        public abstract class usrLockStockDescription : PX.Data.BQL.BqlBool.Field<usrLockStockDescription> {}
        #endregion
    }
}