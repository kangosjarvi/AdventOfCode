using AdventOfCode.Code._2022;
using AdventOfCode.Interface;

namespace AdventOfCode;
internal static class Program
{
    private static void Main()
    {
        IDay day = new Day1();
        day.Play();

        day = new Day2();
        day.Play();

        day = new Day3();
        day.Play();

    }
}
