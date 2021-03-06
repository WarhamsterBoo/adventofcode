using System;
using System.Linq;
using Common;

namespace Day2
{
    public class Puzzle1 : Puzzle
    {
        protected override string PuzzleDirectory => "Day2";

        public override void Solve()
        {
            var validPwds = 0;

            var policies = Input.Select(x => Policy.FromString(x)).ToList();
            foreach (var policy in policies)
            {
                var letterCount = policy.Password.Count(x => x == policy.Letter);
                if (letterCount >= policy.FirstCondition && letterCount <= policy.SecondCondition)
                {
                    validPwds++;
                }
            }

            Console.WriteLine($"Number of incorrect pwds: {validPwds}");
        }
    }
}