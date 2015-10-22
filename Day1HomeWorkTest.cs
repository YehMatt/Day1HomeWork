using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;
using NSubstitute;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InternalLibTests
{
    [TestClass()]
    class Day1HomeWorkTest
    {
        private List<Product> _products;

        [ClassInitialize]
        public void ProductInitialize(TestContext testContext)
        {
            _products = new List<Product>
                {
                    new Product {Id =  1, Cost= 1, Revenue = 11, SellPrice = 21},
                    new Product {Id =  2, Cost= 2, Revenue = 12, SellPrice = 22},
                    new Product {Id =  3, Cost= 3, Revenue = 13, SellPrice = 23},
                    new Product {Id =  4, Cost= 4, Revenue = 14, SellPrice = 24},
                    new Product {Id =  5, Cost= 5, Revenue = 15, SellPrice = 25},
                    new Product {Id =  6, Cost= 6, Revenue = 16, SellPrice = 26},
                    new Product {Id =  7, Cost= 7, Revenue = 17, SellPrice = 27},
                    new Product {Id =  8, Cost= 8, Revenue = 18, SellPrice = 28},
                    new Product {Id =  9, Cost= 9, Revenue = 19, SellPrice = 29},
                    new Product {Id = 10, Cost=10, Revenue = 20, SellPrice = 30},
                    new Product {Id = 11, Cost=11, Revenue = 21, SellPrice = 31},
                };
        }

        [TestMethod()]
        public void getCostSumBy3()
        {
            //arrange
            IProductDao products = Substitute.For<IProductDao>();
            products.getData().Returns(_products);

           var target = new ProductPaging();
           string fieldName = "Cost";
           int groupNumber = 3;

            //act
           var actual = target.getSumByFieldName(fieldName, groupNumber);

           var excepted = new int[] { 6, 15, 24, 24 };

           //assert
           excepted.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void getRevenueSumBy4()
        {
            var target = new ProductPaging();
            string fieldName = "Revenue";
            int groupNumber = 4;

            var actual = target.getSumByFieldName(fieldName, groupNumber);

            var excepted = new int[] { 50, 66, 60 };

            excepted.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
