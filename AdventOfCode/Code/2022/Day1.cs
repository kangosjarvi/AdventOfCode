namespace AdventOfCode.Code._2022;
internal class Day1 : BaseDay
{
    int _maxCalories;
    int _totalCaloriesForTopThree;
    public override void Play()
    {
        //Will show 25th december
        int elf = 1;
        int value = 0;
        Dictionary<int, int> elves = new Dictionary<int, int>();
        foreach (string line in File.ReadLines("job/2022-1.txt"))
        {

        }

        base.Play();
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}, max calories a elf carries is {_maxCalories} and top 3 carry {_totalCaloriesForTopThree}";
    }
}
