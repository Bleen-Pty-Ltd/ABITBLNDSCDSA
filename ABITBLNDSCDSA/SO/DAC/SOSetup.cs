using PX.Data;

namespace PX.Objects.SO
{
  public class SOSetupExt : PXCacheExtension<SOSetup>
  {
        #region UsrCustomField
        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)] 
        [PXUIField(DisplayName = "Lock Stock Description")]
        public virtual bool? UsrLockStockDescription { get;set;}
        public abstract class usrLockStockDescription : PX.Data.BQL.BqlBool.Field<usrLockStockDescription>{}
        #endregion
    }
}