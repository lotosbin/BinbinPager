using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BinbinPager {
    [Serializable]
    [DataContract]
    public class PagedList1<T> : List<T> {
        /// <summary>
        ///     for automaper
        /// </summary>
        public PagedList1() {
        }

        public PagedList1(IEnumerable<T> collection, Pager1 pagerInfo)
            : base(collection) {
            PagerInfo = pagerInfo;
        }


        private Pager1 _pagerInfo;

        public PagedList1(int capacity, Pager1 pagerInfo)
            : base(capacity) {
            PagerInfo = pagerInfo;
        }

        public PagedList1(Pager1 pagerInfo) {
            PagerInfo = pagerInfo;
        }

        [DataMember]
        public Pager1 PagerInfo {
            get { return _pagerInfo; }
            set {
                _pagerInfo = new Pager1(value);
            }
        }

    }
}