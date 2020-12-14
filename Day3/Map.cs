using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
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

        public void Slide(int down, int right)
        {
            while (!IsFinished)
            {
                CurrentPoint.Add(down, right);
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
}