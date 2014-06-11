using System.Collections.Generic;

namespace BinbinPager
{
    public class PagedList<T> : List<T>, IPagedList<T>
    {
        /// <summary>
        /// for automaper
        /// </summary>
        public PagedList()
            : this(new PagerInfo(1, 10, 0))
        {

        }
        public PagedList(IEnumerable<T> collection, IPagerInfo pagerInfo)
            : base(collection)
        {
            PagerInfo = pagerInfo;
        }

        #region Implementation of IPagedList<T>

        public PagedList(int capacity, IPagerInfo pagerInfo)
            : base(capacity)
        {
            PagerInfo = pagerInfo;
        }

        public PagedList(IPagerInfo pagerInfo)
        {
            PagerInfo = pagerInfo;
        }

        private IPagerInfo _pagerInfo;
        public IPagerInfo PagerInfo
        {
            get { return _pagerInfo; }
            set
            {
                _pagerInfo = new PagerInfo(value);
            }
        }

        #endregion
    }
}