using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinbinPager;

namespace BinbinPagerIntergrationServiceStaticRedis
{
    public static class IRedisSortedSetExtension
    {
        //public static PagedList<string> ToPagedList(this IRedisSortedSet source, int pageIndex, int pageSize)
        //{
        //    var count = source.Count;
        //    var pagerInfo = new PagerInfo(pageIndex, pageSize, count);
        //    return source.GetRange(pagerInfo.RecordBegin, pagerInfo.RecordEnd).AsPagedList(pagerInfo);
        //}
    }
}
