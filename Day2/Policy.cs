using System;
using System.Text;

namespace Day2
{
    public class Policy
    {
        public static Policy FromString(string policyString)
        {
            Policy policy = new Policy();

            var firstSplit = policyString.Split(':', StringSplitOptions.TrimEntries);
            var secondSplit = firstSplit[0].Split(' ', StringSplitOptions.TrimEntries);
            var thirdSplit = secondSplit[0].Split('-', StringSplitOptions.TrimEntries);

            policy.Letter = secondSplit[1][0];
            policy.FirstCondition = Int32.Parse(thirdSplit[0]);
            policy.SecondCondition = Int32.Parse(thirdSplit[1]);
            policy.Password = firstSplit[1];

            return policy;
        }

        public char Letter { get; set; }
        public int FirstCondition { get; set; }
        public int SecondCondition { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Letter: {this.Letter}");
            sb.AppendLine($"LowerBoundary: {this.FirstCondition}");
            sb.AppendLine($"UpperBoundary: {this.SecondCondition}");
            sb.AppendLine($"Password: {this.Password}");
            return sb.ToString();
        }
    }
}