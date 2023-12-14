using DanskeTask.Interfaces;

namespace DanskeTask.Mocks
{
    public class MockFileHandlerOperations : IFileOperationsHandler
    {
        void IFileOperationsHandler.WriteToFile(int[] numbers, double sortTimeInMiliseconds, string sortingAlgorithm) { }

        string IFileOperationsHandler.ReadFromFile()
        {
            return "";
        }

        void IFileOperationsHandler.ClearFileContents() { }
    }
}
