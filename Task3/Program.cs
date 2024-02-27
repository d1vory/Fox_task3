namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        const string filename = @"C:\Users\Olexandr\MyProjects\CSHARP\foxminded\task3\Task3\files\numbers.txt";
        var parser = new FileParser(filename);
        Console.WriteLine($"Max sum line is {parser.GetLineWithMaximumSum()}");

        foreach (int i in parser.GetBrokenLinesIndexes())
        {
            Console.Write($"{i}, ");
        }
        
    }
}