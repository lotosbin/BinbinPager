using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BinbinPager {
    [Serializable]
    [DataContract]
    public class PagedList<T> : List<T>, IPagedList<T> {
        /// <summary>
        ///     for automaper
        /// </summary>
        public PagedList()
            : this(new PagerInfo(1, 10, 0)) {
        }

        public PagedList(IEnumerable<T> collection, IPagerInfo pagerInfo)
            : base(collection) {
            PagerInfo = pagerInfo;
        }

        #region Implementation of IPagedList<T>

        private IPagerInfo _pagerInfo;

        public PagedList(int capacity, IPagerInfo pagerInfo)
            : base(capacity) {
            PagerInfo = pagerInfo;
        }

        public PagedList(IPagerInfo pagerInfo) {
            PagerInfo = pagerInfo;
        }

        [DataMember]
        public IPagerInfo PagerInfo {
            get { return _pagerInfo; }
            set { _pagerInfo = new PagerInfo(value); }
        }

        #endregion
    }
}