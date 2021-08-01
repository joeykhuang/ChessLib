using System;
using System.Collections.Generic;
namespace ChessLib.Pieces
{
    public class King : Piece
    {
        public King(bool color, Square square) : base(color, square)
        {
            base.Moves = new List<(int, int)>()
            {
                (1, 0),
                (0, 1),
            };
        }
    }
}
