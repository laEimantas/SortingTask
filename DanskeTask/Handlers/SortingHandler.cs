using DanskeTask.Interfaces;
using System;
using System.Diagnostics;

namespace DanskeTask.Sorting
{
    public class SortingHandler
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private IFileOperationsHandler fileWriteHandler;

        public SortingHandler(IFileOperationsHandler fileWriteHandler) 
        {
            this.fileWriteHandler = fileWriteHandler;
        }

        public int[] BubbleSort(int[] numbersForSorting)
        {
            stopwatch.Start();
            
            for (int i = 0; i < numbersForSorting.Length - 1; i++)
            {
                for (int j = 0; j < numbersForSorting.Length - i - 1; j++)
                {
                    if (numbersForSorting[j] > numbersForSorting[j + 1])
                    {
                        int tempNumber = numbersForSorting[j];
                        numbersForSorting[j] = numbersForSorting[j + 1];
                        numbersForSorting[j + 1] = tempNumber;
                    }
                }
            }
            
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            fileWriteHandler.WriteToFile(numbersForSorting, elapsedTime.TotalMilliseconds, nameof(BubbleSort));

            return numbersForSorting;
        }

        public int[] InsertionSort(int[] numbersForSorting)
        {
            stopwatch.Start();

            for (int i = 0; i < numbersForSorting.Count(); i++)
            {
                int tempNumber = numbersForSorting[i];
                int currentIndex = i;

                while (currentIndex > 0 && numbersForSorting[currentIndex - 1] > tempNumber)
                {
                    numbersForSorting[currentIndex] = numbersForSorting[currentIndex - 1];
                    currentIndex--;
                }

                numbersForSorting[currentIndex] = tempNumber;
            }

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            fileWriteHandler.WriteToFile(numbersForSorting, elapsedTime.TotalMilliseconds, nameof(InsertionSort));

            return numbersForSorting;
        }

    }
}
