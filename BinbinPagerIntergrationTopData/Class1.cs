using BinbinPager;
using Top.Core;
using Top.Data;

namespace BinbinPagerIntergrationTopData {
    public static class Class1 {
        public static void ToPagedList(this SqlBuilder src, Pager1 pager) {
            var pagedList = src.ToPagedList(pager.Skip, pager.PageSize);

        }
    }
}
