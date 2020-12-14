using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Day3
{

    

    

    public class Puzzle1 : Puzzle
    {
        protected override string PuzzleDirectory => "Day3";

        public override void Solve()
        {
            var map = Map.WithTemplate(Input);

            // Console.WriteLine("Initial map state:");
            // map.Print();

            map.Slide(1, 3);

            // Console.WriteLine("Finished map state:");
            // map.Print();
            Console.WriteLine($"Number of trees so far: {map.NumberOfTrees}");
        }
    }
}