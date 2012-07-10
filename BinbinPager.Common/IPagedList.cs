using System.Collections;
using System.Collections.Generic;

namespace BinbinPager
{
    /// <summary>
    /// ��ҳ�б�
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPagedList<T> : IList<T>, IList
    {

        IPagerInfo PagerInfo { get; }
    }
}