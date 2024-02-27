namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        string filename;
        if (args.Length == 0)
        {
            Console.WriteLine("Enter a path to file: ");
            filename = Console.ReadLine().Trim();
        }
        else
        {
            filename = args[0];
        }

        try
        {
            var parser = new FileParser(filename);

            Console.WriteLine($"Line with maximal sum of elements is {parser.GetLineWithMaximumSum()}");

            var brokenLinesIndexes = parser.GetBrokenLinesIndexes();

            Console.Write("Broken lines are: [");
            foreach (int i in parser.GetBrokenLinesIndexes())
            {
                Console.Write($"{i}, ");
            }
            Console.Write("]\n");

        }
        catch (IOException ex)
        {
            Console.WriteLine("Given path is not valid!");
            return;
        }

    }
}