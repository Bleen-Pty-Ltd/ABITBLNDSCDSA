using PX.Data;

namespace PX.Objects.RQ
{
    public class RQRequisitionEntry_Extension : PXGraphExtension<RQRequisitionEntry>
    {
        #region Event Handlers
        protected void _(Events.RowSelected<RQRequisitionLine> e)
        {
            if (e.Row == null) return;
            RQSetupExt rQSetup = Base.Setup.Current.GetExtension<RQSetupExt>();
            if (rQSetup.UsrLockStockDescription == true)
                PXUIFieldAttribute.SetEnabled<RQRequisitionLine.description>(e.Cache, null, Base.Lines.Current.LineType != "GI");
        }
        #endregion
    }
}