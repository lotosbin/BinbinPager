namespace BinbinPager
{
    public class PagerInfoBaseZore : PagerInfoBaseBase
    {
        public PagerInfoBaseZore(PagerBase pagerBase) : base(pagerBase)
        {
        }

        public override int PageIndex { get; protected set; }
        public override int PageCount { get; protected set; }
        public override int RecordCount { get; protected set; }
        public override bool HasPrevPage { get; protected set; }
        public override bool HasNextPage { get; protected set; }
        public override int PageSize { get; protected set; }
        public override int Skip { get; protected set; }
    }
}