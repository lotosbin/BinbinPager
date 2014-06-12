using System;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinbinPager.Common.TestProject
{
    [TestClass]
    public class UnitTest1
    {
        class a
        {
            public string Name { get; set; }

        }

        class b
        {
            public string Name { get; set; }
        }


        [TestMethod]
        public void Test2()
        {
            {
                var pager = new PagerInfoBaseOne(0, 2, 0);
                Assert.AreEqual(1, pager.PageIndex);
                Assert.AreEqual(2, pager.PageSize);
                Assert.AreEqual(0, pager.RecordCount);
                Assert.AreEqual(0, pager.PageCount);
                Assert.AreEqual(false, pager.HasPrevPage);
                Assert.AreEqual(false, pager.HasNextPage);
                Assert.AreEqual(0, pager.Skip);
            }
            {
                var pager = new PagerInfoBaseOne(0, 2, 3);
                Assert.AreEqual(1, pager.PageIndex);
                Assert.AreEqual(2, pager.PageSize);
                Assert.AreEqual(3, pager.RecordCount);
                Assert.AreEqual(2, pager.PageCount);
                Assert.AreEqual(false, pager.HasPrevPage);
                Assert.AreEqual(true, pager.HasNextPage);
                Assert.AreEqual(0, pager.Skip);
            }
            {
                var pager = new PagerInfoBaseOne(2, 2, 3);
                Assert.AreEqual(2, pager.PageIndex);
                Assert.AreEqual(2, pager.PageSize);
                Assert.AreEqual(3, pager.RecordCount);
                Assert.AreEqual(2, pager.PageCount);
                Assert.AreEqual(true, pager.HasPrevPage);
                Assert.AreEqual(false, pager.HasNextPage);
                Assert.AreEqual(2, pager.Skip);
            }
            {
                var pager = new PagerInfoBaseOne(2, 2, 4);
                Assert.AreEqual(2, pager.PageIndex);
                Assert.AreEqual(2, pager.PageSize);
                Assert.AreEqual(4, pager.RecordCount);
                Assert.AreEqual(2, pager.PageCount);
                Assert.AreEqual(true, pager.HasPrevPage);
                Assert.AreEqual(false, pager.HasNextPage);
                Assert.AreEqual(2, pager.Skip);
            }
            {
                var pager = new PagerInfoBaseOne(3, 2, 8);
                Assert.AreEqual(3, pager.PageIndex);
                Assert.AreEqual(2, pager.PageSize);
                Assert.AreEqual(8, pager.RecordCount);
                Assert.AreEqual(4, pager.PageCount);
                Assert.AreEqual(true, pager.HasPrevPage);
                Assert.AreEqual(true, pager.HasNextPage);
                Assert.AreEqual(4, pager.Skip);
            }

        }
    }
}
