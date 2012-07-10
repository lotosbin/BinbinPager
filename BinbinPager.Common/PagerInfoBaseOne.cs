namespace BinbinPager
{
    /// <summary>
    /// ÷µ∂‘œÛ
    /// </summary>
    public class PagerInfoBaseOne : IPagerInfo
    {
        public PagerBase PagerBase { get; set; }
        public PagerInfoBaseOne(IPagerInfo pagerInfo)
            : this(pagerInfo.PageIndex, pagerInfo.PageSize, pagerInfo.RecordCount)
        {

        }
        public PagerInfoBaseOne(int pageIndex, int pageSize, int recordCount)
        {
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.RecordCount = recordCount;
        }


        #region Implementation of IPagerInfo

        public int PageSize { get; private set; }

        public int Skip { get; private set; }

        public int PageIndex { get; private set; }
        public int PageCount { get; private set; }
        public int RecordCount { get; private set; }
        public bool HasPrevPage { get; private set; }
        public bool HasNextPage { get; private set; }

        #endregion
    }
}