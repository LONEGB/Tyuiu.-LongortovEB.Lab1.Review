using Tyuiu._LongortovEB.Lab1.Review.V4.Lib;
using Xunit;

namespace Tyuiu._LongortovEB.Lab1.Review.V4.Test;

public class UnitTest1
{
    [Fact]
    public void CheckCalc()
    {
        double x = 4;
        double y = 3;

        DataService ds = new DataService();

        double res = ds.Calc(x, y);

        double true_value = 1.288;

        Assert.Equals(true_value, res);
    }
}