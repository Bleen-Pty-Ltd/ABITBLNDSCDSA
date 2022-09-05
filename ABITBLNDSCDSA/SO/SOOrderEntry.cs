using PX.Data;

namespace PX.Objects.SO
{
    public class SOOrderEntry_Extension : PXGraphExtension<SOOrderEntry>
    {
        #region Event Handlers
        protected void _(Events.RowSelected<SOLine> e)
        {
            if (e.Row == null) return;
            SOSetupExt sOSetupExt = Base.sosetup.Current.GetExtension<SOSetupExt>();
            if (sOSetupExt.UsrLockStockDescription == true)
            {
                PXUIFieldAttribute.SetEnabled<SOLine.tranDesc>(e.Cache, null, Base.Transactions.Current.LineType != "GI");
            }
        }
        #endregion
    }
}