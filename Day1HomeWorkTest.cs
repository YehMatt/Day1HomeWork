using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InternalLibTests
{
    [TestClass()]
    class Day1HomeWorkTest
    {
        [TestMethod()]
        public void getCostSumBy3()
        {
           var homeWorkPaging = new HomeWorkPaging();
           int groupNumber = 3;

           var target = homeWorkPaging.getCostSumArray(groupNumber);

           var excepted = new int[] { 6, 15, 24, 24 };

           excepted.ToExpectedObject().ShouldEqual(target);
        }

        [TestMethod()]
        public void getRevenueSumBy4()
        {
            var homeWorkPaging = new HomeWorkPaging();
            int groupNumber = 4;

            var target = homeWorkPaging.getRevenueArray(groupNumber);

            var excepted = new int[] { 50, 66, 60 };

            excepted.ToExpectedObject().ShouldEqual(target);
        }
    }
}
