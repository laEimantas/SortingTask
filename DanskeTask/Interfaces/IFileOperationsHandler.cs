namespace DanskeTask.Interfaces
{
    public interface IFileOperationsHandler
    {
        void WriteToFile(int[] numbers, double sortTimeInMiliseconds, string sortingAlgorithm);

        string ReadFromFile();

        void ClearFileContents();

    }
}
