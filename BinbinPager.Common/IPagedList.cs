using System.Collections;
using System.Collections.Generic;

namespace BinbinPager
{
    /// <summary>
    /// ∑÷“≥¡–±Ì
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPagedList<T> : IList<T>, IList
    {

        IPagerInfo PagerInfo { get; }
    }
}