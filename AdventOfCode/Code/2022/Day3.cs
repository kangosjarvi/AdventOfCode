
namespace AdventOfCode.Code._2022
{
    internal class Day3 : BaseDay
    {
        int _sumOfPoints ;
        int _sumOfPoints2 ;
        public override void Play()
        {
            //Will show 25th december
            var lines = File.ReadAllLines("job/2022-3.txt");
            base.Play();
        }

        public override string ToString()
        {
            return $"{GetType().Name}, your total score is {_sumOfPoints} and badge score is {_sumOfPoints2}";
        }
    }
}
