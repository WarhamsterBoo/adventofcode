using System;
using System.Linq;
using Common;

namespace Day1 {
    public class Puzzle1 : Puzzle {
        protected override string PuzzleDirectory => "Day1";

        public void Solve() {
            int ans = 0;
            var intInput = Input.Select(x => Int32.Parse(x)).ToList();
            for (var i = 0; i < Input.Count; i++) {
                for (var j = i; j < Input.Count; j++) {
                    if (intInput[i] + intInput[j] == 2020) {
                        ans = intInput[i] * intInput[j];
                    }
                }
            }

            Console.WriteLine($"Answer: {ans}");
        }
    }
}