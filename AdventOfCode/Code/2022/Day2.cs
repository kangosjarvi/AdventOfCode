namespace AdventOfCode.Code._2022
{
    internal class Day2 : BaseDay
    {
        private const int WinnerPoints = 6;
        private const int DrawPoints = 3;
        private int _secretTotalScore;
        private int _totalScore;



        public override void Play()
        {
            //Will show 25th december
            foreach (string line in File.ReadLines("job/2022-2.txt"))
            {
                var game = line.Split(" ");

          //      _totalScore += StrategyGuide(game[0], game[1], false);
          //      _secretTotalScore += StrategyGuide(game[0], game[1], true);

            }
            base.Play();
        }

        public override string ToString()
        {
            return $"{GetType().Name}, your total normal score is {_totalScore} and secret strategy score {_secretTotalScore}";
        }
    }

}
