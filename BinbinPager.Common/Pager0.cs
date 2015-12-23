namespace BinbinPager {
    /// <summary>
    /// note 值对象属性不能set
    /// </summary>
    public class Pager0 {
        public Pager0(Pager0 pager0) {
            this.PageIndex = pager0.PageIndex;
            this.PageSize = pager0.PageSize;
            this.RecordCount = pager0.RecordCount;
        }

        public Pager0(Pager0 pager0, int recordCount) : this(pager0) {
            this.RecordCount = recordCount;
        }
        public Pager0(Pager1 pager1) {
            this.PageIndex = pager1.PageIndex - 1;
            this.PageSize = pager1.PageSize;
            this.RecordCount = pager1.RecordCount;
        }
        public Pager0(Pager1 pager1, int recordCount) : this(pager1) {
            this.RecordCount = recordCount;
        }
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int RecordCount { get; private set; }
    }
}