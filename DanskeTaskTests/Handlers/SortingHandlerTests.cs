using Microsoft.VisualStudio.TestTools.UnitTesting;
using DanskeTask.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanskeTask.Mocks;

namespace DanskeTask.Sorting.Tests
{
    [TestClass()]
    public class SortingHandlerTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            SortingHandler sortingHandler = new SortingHandler(new MockFileHandlerOperations());

            int[] numbers = { 1, 4, 2, 3, 5 };
            int[] expectedResult = { 1, 2, 3, 4, 5 };

            numbers = sortingHandler.BubbleSort(numbers);

            CollectionAssert.AreEqual(numbers, expectedResult);
        }

        [TestMethod()]
        public void InsertionSortTest()
        {
            SortingHandler sortingHandler = new SortingHandler(new MockFileHandlerOperations());

            int[] numbers = { 1, 4, 2, 3, 5 };
            int[] expectedResult = { 1, 2, 3, 4, 5 };

            numbers = sortingHandler.InsertionSort(numbers);

            CollectionAssert.AreEqual(numbers, expectedResult);
        }
    }
}