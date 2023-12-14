using DanskeTask.Interfaces;

namespace DanskeTask.Sorting
{
    public class FileOperationsHandler: IFileOperationsHandler
    {
        private string filePath;
        
        public FileOperationsHandler ()
        {
            filePath = "./Output/SortingOutput.txt";
        }

        public void WriteToFile(int[] numbers, double sortTimeInMiliseconds, string sortingAlgorithm)
        {
            if(filePath == null)
            {
                return;
            }

            string outputTimeType = (sortTimeInMiliseconds > 1000) ? " seconds" : " miliseconds";
            double outputTimeAmount = (sortTimeInMiliseconds > 1000) ? sortTimeInMiliseconds / 1000 : sortTimeInMiliseconds;

            string fileInput = string.Empty;

            foreach (int number in numbers)
            {
                fileInput = fileInput + number + ",";
            }

            fileInput = fileInput.TrimEnd(',');

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(fileInput);

                writer.WriteLine("Above numbers were sorted using " 
                    + sortingAlgorithm 
                    + " algorithm and it took: " 
                    + outputTimeAmount 
                    + outputTimeType);
            }
        }

        public string ReadFromFile()
        {
            string fileOutputTotal = string.Empty;

            using (StreamReader file = new StreamReader(filePath))
            {
                string fileOutputLine = string.Empty;

                while ((fileOutputLine = file.ReadLine()) != null)
                {
                    fileOutputTotal += fileOutputLine + '\n';
                }
                file.Close();
            }

            return fileOutputTotal;
        }
        
        public void ClearFileContents()
        {
            File.WriteAllText(filePath, string.Empty);
        }
    }
}
