using System;
namespace ChessLib
{
    public class Square
    {
        public int Row { get; }
        public int Column { get; }
        private char[] _columnNames = new char[8] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
        public Pieces.Piece SquarePiece { get; set; }

        public Square(int row, int column)
        {
            Row = row;
            Column = column;   
        }

        public string GetPosition()
        {
            return _columnNames[Column] + Row.ToString();
	    }
    }
}
