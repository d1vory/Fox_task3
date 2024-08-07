using System.Globalization;

namespace Task3;

public class Line
{
    public bool IsBroken { get; private set; }
    private decimal[] _numbersSet;
    public int Index { get; private set; }

    public Line(string line, int index)
    {
        ParseLine(line);
        Index = index;
    }

    public decimal GetSum()
    {
        if (IsBroken)
        {
            throw new InvalidOperationException("Cant get a sum of a broken line!");
        }
        return _numbersSet.Sum();
    }

    private void ParseLine(string line)
    {
        var numbersList = new List<decimal>();
        var culture = new CultureInfo("en-US", false);
        var style = NumberStyles.Number;
        
        foreach (var numString in line.Split(','))
        {
            var isValid = decimal.TryParse(numString, style, culture, out var number);
            if (isValid)
            {
                numbersList.Add(number);
            }
            else
            {
                IsBroken = true;
                break;
            }
        }

        _numbersSet = numbersList.ToArray();
    }
}