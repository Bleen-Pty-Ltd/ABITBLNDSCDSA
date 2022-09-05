using PX.Common;
using PX.Data;

namespace PX.Objects.PO
{
    public class POOrderEntry_Extension : PXGraphExtension<PX.Objects.PO.POOrderEntry>
    {
        #region Event Handlers
        protected virtual void _(Events.RowSelected<POLine> e)
        {
            if (e.Row == null) return;
            POSetupExt pOSetupExt = Base.POSetup.Current.GetExtension<POSetupExt>();

            if (pOSetupExt.UsrLockStockDescription == true)
                PXUIFieldAttribute.SetEnabled<POLine.tranDesc>(e.Cache, null, Base.Transactions.Current.LineType != "G");
        }
        #endregion
    }
}