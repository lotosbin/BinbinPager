namespace BinbinPager {
    /// <summary>
    /// ��1��ʼ�ķ�ҳ��Ϣ
    /// </summary>
    public abstract class PagerInfoBaseBase : IPagerInfo {
        public abstract int PageIndex { get; protected set; }
        public abstract int PageCount { get; protected set; }
        public abstract int RecordCount { get; protected set; }
        public abstract bool HasPrevPage { get; protected set; }
        public abstract bool HasNextPage { get; protected set; }
        public abstract int PageSize { get; protected set; }
        public abstract int Skip { get; protected set; }
    }

}