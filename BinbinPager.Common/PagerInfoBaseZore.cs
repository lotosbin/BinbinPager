namespace BinbinPager {
    public class PagerInfoBaseZore : IPagerInfo {
        public int PageIndex { get; protected set; }
        public int PageCount { get; protected set; }
        public int RecordCount { get; protected set; }
        public bool HasPrevPage { get; protected set; }
        public bool HasNextPage { get; protected set; }
        public int PageSize { get; protected set; }
        public int Skip { get; protected set; }
    }
}