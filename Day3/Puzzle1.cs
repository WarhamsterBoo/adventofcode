using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Day3
{

    public class MapTile
    {
        public const string Tree = "#";
        public const string Snow = ".";

        public const string Ok = "O";
        public const string Boom = "X";
    }

    public class Point
    {
        public int Row;
        public int Col;

        public Point(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public void Add(int rowAdd, int colAdd)
        {
            Row += rowAdd;
            Col += colAdd;
        }

        public override string ToString()
        {
            return $"Row: {Row}. Col: {Col}";
        }
    }

    public class Map
    {

        public static Map WithTemplate(List<string> input)
        {
            return new Map(input);
        }

        private List<List<string>> _template = new List<List<string>>();

        private List<List<string>> _tiles = new List<List<string>>();

        public int RowNum => _tiles.Count;
        public int ColNum => _tiles[0].Count;

        public bool IsFinished => CurrentPoint.Row >= _tiles.Count;

        public int NumberOfTrees { get; private set; }

        public Point CurrentPoint { get; private set; } = new Point(0, 0);

        private Map(List<string> input)
        {
            foreach (var row in input)
            {
                _template.Add(row.ToCharArray().Select(x => x.ToString()).ToList());
                _tiles.Add(row.ToCharArray().Select(x => x.ToString()).ToList());
            }
        }

        public void Slide()
        {
            while (!IsFinished)
            {
                CurrentPoint.Add(1, 3);
                if (CurrentPoint.Col >= _tiles[0].Count)
                {
                    for (var i = 0; i < _tiles.Count; i++)
                    {
                        _tiles[i].AddRange(_template[i]);
                    }
                }
                if (IsFinished)
                {
                    break;
                }
                if (_tiles[CurrentPoint.Row][CurrentPoint.Col] == MapTile.Tree)
                {
                    _tiles[CurrentPoint.Row][CurrentPoint.Col] = MapTile.Boom;
                    NumberOfTrees++;
                }
                else
                {
                    _tiles[CurrentPoint.Row][CurrentPoint.Col] = MapTile.Ok;
                }
            }
        }

        public void Print()
        {
            foreach (var tileRow in _tiles)
            {
                Console.WriteLine(string.Join("", tileRow));
            }
        }
    }

    public class Puzzle1 : Puzzle
    {
        protected override string PuzzleDirectory => "Day3";

        public override void Solve()
        {
            var map = Map.WithTemplate(Input);

            // Console.WriteLine("Initial map state:");
            // map.Print();

            map.Slide();

            Console.WriteLine("Finished map state:");
            map.Print();
            Console.WriteLine($"Number of trees so far: {map.NumberOfTrees}");
        }
    }
}