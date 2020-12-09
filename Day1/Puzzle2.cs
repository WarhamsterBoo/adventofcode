using System;
using System.Linq;
using Common;

namespace Day1 {
    public class Puzzle2 : Puzzle {
        protected override string PuzzleDirectory => "Day1";

        public override void Solve() {
            int ans = 0;
            var intInput = Input.Select(x => Int32.Parse(x)).ToList();
            for (var i = 0; i < intInput.Count; i++) {
                for (var j = i+1; j < intInput.Count-1; j++) {
                    for (var k = j + 1; k < intInput.Count-2; k++) {
                        if (intInput[i] + intInput[j] + intInput[k] == 2020) {
                            ans = intInput[i] * intInput[j] * intInput[k];
                        }
                    }
                }
            }

            Console.WriteLine($"Answer: {ans}");
        }
    }
}