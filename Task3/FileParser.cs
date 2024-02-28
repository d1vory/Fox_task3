namespace Task3;

public class FileParser
{
    private string _filename;
    private Line[] _lines;
    public int LineWithMaximumSum { get; set; }
    

    public FileParser(string filename)
    {
        _filename = filename;
        ParseFile();
    }
    
    public int[] GetBrokenLinesIndexes()
    {
        var lineIndexes = from line in _lines
            where line.IsBroken
            select line.Index;
        return lineIndexes.ToArray();
    }
    
    private void ParseFile()
    {
        var fileLines =  File.ReadLines(_filename);
        _lines = new Line[fileLines.Count()];
        int i = 0;
        LineWithMaximumSum = -1;
        var maxSum = decimal.MinValue; 
        
        foreach (var lineStr in fileLines)
        {
            var line = new Line(lineStr, i + 1);
            _lines[i] = line;
            i++;
            try
            {
                var lineSum = line.GetSum();
                if (lineSum > maxSum)
                {
                    maxSum = lineSum;
                    LineWithMaximumSum = line.Index;
                }
            }
            catch (InvalidOperationException e)
            {
                continue;
            }
        }
    }
}