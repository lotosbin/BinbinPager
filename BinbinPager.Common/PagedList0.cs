using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BinbinPager {
    [Serializable]
    [DataContract]
    public class PagedList0<T> : List<T> {
        /// <summary>
        ///     for automaper
        /// </summary>
        public PagedList0() {
        }

        public PagedList0(IEnumerable<T> collection, Pager0 pagerInfo)
            : base(collection) {
            PagerInfo = pagerInfo;
        }


        private Pager0 _pagerInfo;

        public PagedList0(int capacity, Pager0 pagerInfo)
            : base(capacity) {
            PagerInfo = pagerInfo;
        }

        public PagedList0(Pager0 pagerInfo) {
            PagerInfo = pagerInfo;
        }

        [DataMember]
        public Pager0 PagerInfo {
            get { return _pagerInfo; }
            set {
                _pagerInfo = new Pager0(value);
            }
        }

    }
}