using PX.Data;

namespace PX.Objects.PO
{
    public class POSetupExt : PXCacheExtension<POSetup>
  {
        #region UsrLockStockDescription
        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]    
        [PXUIField(DisplayName = "Lock Stock Description")]
        public virtual bool? UsrLockStockDescription {get;set;}
        public abstract class usrLockStockDescription : PX.Data.BQL.BqlBool.Field<usrLockStockDescription> { }
        #endregion
    }
}