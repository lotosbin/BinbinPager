using System;
using System.Runtime.Serialization;

namespace BinbinPager
{
    [Obsolete("Use PagerInfoBaseOne")]
    [Serializable]
    [DataContract]
    public class PagerInfo : PagerInfoBaseOne
    {
        public PagerInfo(IPagerInfo pagerInfo)
            : this((PagerInfoBaseOne)pagerInfo)
        {

        }
        public PagerInfo(PagerInfoBaseOne pagerInfo)
            : base(pagerInfo)
        {
        }

        public PagerInfo(int pageIndex, int pageSize, int recordCount)
            : base(pageIndex, pageSize, recordCount)
        {
        }
    }
}