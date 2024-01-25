namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader inputStreamReader = new StreamReader(inputFilePath))
            {
                using (StreamWriter outputStreamWriter = new StreamWriter(outputFilePath))
                {
                    int line = 0;

                    while (!inputStreamReader.EndOfStream)
                    {
                        line++;

                        if (line % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            outputStreamWriter.WriteLine(inputStreamReader.ReadLine());
                        }
                    }
                }
            }
        }
    }
}