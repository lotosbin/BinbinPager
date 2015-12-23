using BinbinPager;
using System.Linq;

namespace BinbinPagerIntergrationLinqToSql {

    public static class IPagedListExtension {
        public static IPagedList<T> ToPagedList<T>(this IQueryable<T> source, int pageIndex, int pageSize) {
            int count = source.Count();
            var pager = new PagerInfo(pageIndex, pageSize, count);
            var list = source.Skip(pager.Skip).Take(pager.PageSize).ToList();
            return new PagedList<T>(list, pager);
        }

        public static PagedList0<T> ToPagedList<T>(this IQueryable<T> source, Pager0 pager) {
            int count = source.Count();
            var list = source.Skip(pager.PageIndex * pager.PageSize).Take(pager.PageSize).ToList();
            return new PagedList0<T>(list, new Pager0(pager, count));
        }
        public static PagedList0<T> ToPagedList<T>(this IQueryable<T> source, Pager1 pager) {
            return ToPagedList(source, new Pager0(pager));
        }
    }
}
