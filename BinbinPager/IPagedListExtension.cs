using System.Linq;

namespace BinbinPager
{
    public static class IPagedListExtension
    {
        public static IPagedList<T> ToPagedList<T>(this IQueryable<T> source, int pageIndex, int pageSize)
        {
            int count = source.Count();
            var pager = new PagerInfo(pageIndex, pageSize, count);
            var list = source.Skip(pager.Skip).Take(pager.PageSize).ToList();
            return new PagedList<T>(list, pager);
        }
    }
}