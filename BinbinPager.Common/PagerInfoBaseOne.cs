using System;
using System.Runtime.Serialization;

namespace BinbinPager {
    /// <summary>
    ///     值对象
    /// </summary>
    [Serializable]
    [DataContract]
    public class PagerInfoBaseOne : IPagerInfo {
        private int _pageIndex;
        private int _pageSize;

        public PagerInfoBaseOne()
            : this(1, 10, 0) {

        }
        public PagerInfoBaseOne(PagerInfoBaseOne pagerInfo)
            : this(pagerInfo.PageIndex, pagerInfo.PageSize, pagerInfo.RecordCount) {
        }

        public PagerInfoBaseOne(int pageIndex, int pageSize, int recordCount) {
            //note: 注意属性设置顺序，先设置数据总数，在设置分页大小，然后设置页码
            RecordCount = recordCount;
            PageSize = pageSize;
            PageIndex = pageIndex;
        }

        #region Implementation of IPagerInfo

        [DataMember]
        public int PageSize {
            get { return _pageSize; }
            private set {
                if (value < 1) {
                    _pageSize = 10;
                    return;
                }
                _pageSize = value;
            }
        }

        [DataMember]
        public int Skip => (this.PageIndex - 1) * this.PageSize;

        [DataMember]
        public int PageIndex {
            get { return _pageIndex; }
            private set {
                if (value < 1) {
                    _pageIndex = 1;
                    return;
                }
                if (value > PageCount) {
                    _pageIndex = PageCount;
                    return;
                }
                _pageIndex = value;
            }
        }

        [DataMember]
        public int PageCount => this.RecordCount / PageSize + (this.RecordCount % PageSize == 0 ? 0 : 1);

        [DataMember]
        public int RecordCount { get; private set; }

        [DataMember]
        public bool HasPrevPage => PageIndex > 1;

        [DataMember]
        public bool HasNextPage => PageIndex < PageCount;

        #endregion
    }
}