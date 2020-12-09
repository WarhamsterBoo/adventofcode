using System;
using System.Linq;
using Common;

namespace Day2
{
    public class Puzzle2 : Puzzle
    {
        protected override string PuzzleDirectory => "Day2";

        public override void Solve()
        {
            var validPwds = 0;

            var policies = Input.Select(x => Policy.FromString(x)).ToList();
            foreach (var policy in policies)
            {
                if (policy.Password[policy.FirstCondition - 1] == policy.Letter
                 && policy.Password[policy.SecondCondition - 1] != policy.Letter
                 || policy.Password[policy.FirstCondition - 1] != policy.Letter
                 && policy.Password[policy.SecondCondition - 1] == policy.Letter)
                {
                    validPwds++;
                }
            }

            Console.WriteLine($"Number of incorrect pwds: {validPwds}");
        }
    }
}