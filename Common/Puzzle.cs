using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Common
{
    public abstract class Puzzle {
        protected virtual string PuzzleDirectory => string.Empty;
        protected List<string> Input = new List<string>();
        
        protected Puzzle() {
            Input = File.ReadAllLines(@$"./{PuzzleDirectory}/input.txt").ToList();
        }
    }
}