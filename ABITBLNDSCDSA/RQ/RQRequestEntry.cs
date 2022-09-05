using PX.Data;
using PX.Objects.IN;

namespace PX.Objects.RQ
{
    public class RQRequestEntry_Extension : PXGraphExtension<RQRequestEntry>
  {
        #region Event Handlers
        protected void _(Events.FieldUpdated<RQRequestLine, RQRequestLine.inventoryID> e)
        {
            RQRequestLine row = e.Row;
            if (row == null) return;

            InventoryItem inventoryItem = PXSelect<InventoryItem,
                Where<InventoryItem.inventoryID, Equal<Current<RQRequestLine.inventoryID>>>>.Select(Base);
            if (inventoryItem != null)
                PXCache<RQRequestLine>.GetExtension<RQRequestLineExt>(row).UsrItemType = inventoryItem.ItemType;
        }

        protected void _(Events.RowSelected<RQRequestLine> e)
        {
            RQRequestLine row = e.Row;
            if (row == null) return;
            RQRequestLineExt rowExt = e.Row.GetExtension<RQRequestLineExt>();
            RQSetupExt rQSetupExt = Base.Setup.Current.GetExtension<RQSetupExt>();
            if (rQSetupExt.UsrLockStockDescription == true)
                PXUIFieldAttribute.SetEnabled<RQRequestLine.description>(e.Cache, null, rowExt.UsrItemType != "F");
        }
        #endregion
    }
}