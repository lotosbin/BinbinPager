namespace BinbinPager
{
    public class PagerInfo : PagerInfoBaseOne
    {
        public PagerInfo(IPagerInfo pagerInfo)
            : base(pagerInfo)
        {
        }

        public PagerInfo(int pageIndex, int pageSize, int recordCount)
            : base(pageIndex, pageSize, recordCount)
        {
        }
    }
}