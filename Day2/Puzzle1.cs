using System;
using System.Linq;
using System.Text;
using Common;

namespace Day2
{
    internal class Policy
    {
        public static Policy FromString(string policyString) {
            Policy policy = new Policy();

            var firstSplit = policyString.Split(':', StringSplitOptions.TrimEntries);
            var secondSplit = firstSplit[0].Split(' ', StringSplitOptions.TrimEntries);
            var thirdSplit = secondSplit[0].Split('-', StringSplitOptions.TrimEntries);

            policy.Letter = secondSplit[1][0];
            policy.LowerBoundary = Int32.Parse(thirdSplit[0]);
            policy.UpperBoundary = Int32.Parse(thirdSplit[1]);
            policy.Password = firstSplit[1];

            return policy;
        }

        public char Letter { get; set; }
        public int LowerBoundary {get;set;}
        public int UpperBoundary {get;set;}
        public string Password {get;set;}

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Letter: {this.Letter}");
            sb.AppendLine($"LowerBoundary: {this.LowerBoundary}");
            sb.AppendLine($"UpperBoundary: {this.UpperBoundary}");
            sb.AppendLine($"Password: {this.Password}");
            return sb.ToString();
        }
    }
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
                if (letterCount >= policy.LowerBoundary && letterCount <= policy.UpperBoundary) {
                    validPwds++;
                }
            }

            Console.WriteLine($"Number of incorrect pwds: {validPwds}");
        }
    }
}