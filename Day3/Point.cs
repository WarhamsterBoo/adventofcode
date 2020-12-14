namespace Day3
{
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
}