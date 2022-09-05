using PX.Data;

namespace PX.Objects.RQ
{
    public class RQRequestLineExt : PXCacheExtension<RQRequestLine>
    {
        #region UsrItemType
        [PXDBString(1)]
        public virtual string UsrItemType { get; set; }
        public abstract class usrItemType : PX.Data.BQL.BqlString.Field<usrItemType> { }
        #endregion
    }
}