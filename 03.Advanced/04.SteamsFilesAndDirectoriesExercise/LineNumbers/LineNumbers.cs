namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = lines[i].Where(char.IsLetter).Count();
                int punctuationsCount = lines[i].Where(char.IsPunctuation).Count();

                lines[i] = $"Line {i + 1}: {lines[i]} ({lettersCount})({punctuationsCount})";
            }

            File.WriteAllLines(outputFilePath, lines);
        }
    }
}