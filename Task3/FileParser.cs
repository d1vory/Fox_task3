namespace Task3;

public class FileParser
{
    private string Filename;
    private Line[] Lines;

    public FileParser(string filename)
    {
        Filename = filename;
        ParseFile();
    }

    
    public  int GetLineWithMaximumSum()
    {
        var maxSumLineIndex = -1;
        var maxSum = decimal.MinValue; 
        foreach (var line in Lines)
        {
            try
            {
                var lineSum = line.GetSum();
                if (lineSum > maxSum)
                {
                    maxSum = lineSum;
                    maxSumLineIndex = line.Index;
                }
            }
            catch (InvalidOperationException e)
            {
                continue;
            }
        }

        return maxSumLineIndex;
    }

    public int[] GetBrokenLinesIndexes()
    {
        var lineIndexes = new List<int>();
        foreach (var line in Lines)
        {
            if (line.IsBroken)
            {
                lineIndexes.Add(line.Index);
            }
        }

        return lineIndexes.ToArray();
    }
    
    private void ParseFile()
    {
        var fileLines =  File.ReadLines(Filename);
        Lines = new Line[fileLines.Count()];
        int i = 0;
        
        foreach (var lineStr in fileLines)
        {
            Lines[i] = new Line(lineStr, i + 1);
            i++;
        }
    }
    
}