using System.Globalization;

namespace Task3;

public class Line
{
    public bool IsBroken = false;
    private decimal[] NumbersSet;
    public readonly int Index;

    public Line(string line, int index)
    {
        ParseLine(line);
        Index = index;
    }

    public decimal GetSum()
    {
        return NumbersSet.Sum();
    }

    private void ParseLine(string line)
    {
        var numbersList = new List<decimal>();
        NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;
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

        NumbersSet = numbersList.ToArray();
    }


}