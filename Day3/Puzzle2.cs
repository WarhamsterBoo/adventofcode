using System;
using Common;

namespace Day3
{
    public class Puzzle2 : Puzzle
    {
        protected override string PuzzleDirectory => "Day3";

        public override void Solve()
        {
            var slopesMult = 1;
            var map = Map.WithTemplate(Input);
            map.Slide(1, 1);
            Console.WriteLine(map.NumberOfTrees);
            slopesMult = slopesMult * map.NumberOfTrees;

            map = Map.WithTemplate(Input);
            map.Slide(1, 3);
            Console.WriteLine(map.NumberOfTrees);
            slopesMult = slopesMult * map.NumberOfTrees;

            map = Map.WithTemplate(Input);
            map.Slide(1, 5);
            Console.WriteLine(map.NumberOfTrees);
            slopesMult = slopesMult * map.NumberOfTrees;

            map = Map.WithTemplate(Input);
            map.Slide(1, 7);
            Console.WriteLine(map.NumberOfTrees);
            slopesMult = slopesMult * map.NumberOfTrees;

            map = Map.WithTemplate(Input);
            map.Slide(2, 1);
            Console.WriteLine(map.NumberOfTrees);
            slopesMult = slopesMult * map.NumberOfTrees;

            // Console.WriteLine("Finished map state:");
            // map.Print();
            Console.WriteLine($"Number of trees so far: {slopesMult}");
        }
    }
}