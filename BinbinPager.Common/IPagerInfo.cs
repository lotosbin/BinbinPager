using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinbinPager
{
    /// <summary>
    /// 分页信息
    /// </summary>
    public interface IPagerInfo
    {
        int PageIndex { get; }
        int PageCount { get; }
        int RecordCount { get; }
        bool HasPrevPage { get; }
        bool HasNextPage { get; }
        int PageSize { get;  }
        int Skip { get; }
    }
}
