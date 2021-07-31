using System;
namespace ChessLib
{
    public class Square
    {
        protected int Row { get; }
        protected int Column { get; }
        public Pieces.Piece SquarePiece { get; set; }

        public Square(int row, int column)
        {
            Row = row;
            Column = column;   
        }

        public string GetPosition()
        {
            return Row + "," + Column;
	    }
    }
}
