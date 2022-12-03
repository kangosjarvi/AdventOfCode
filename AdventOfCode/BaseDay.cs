using AdventOfCode.Interface;

namespace AdventOfCode
{
    internal abstract class BaseDay : IDay
    {
        public virtual void Play()
        {
            Console.WriteLine(this);
        }
        public abstract override string ToString();
    }
}
