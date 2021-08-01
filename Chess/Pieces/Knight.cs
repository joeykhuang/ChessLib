using System;
using System.Collections.Generic;
namespace ChessLib.Pieces
{
    public class Knight : Piece
    {
        public Knight(bool color, Square square) : base(color, square)
        {
            base.Moves = new List<(int, int)>()
            {
                (1, 2),
                (2, 1),
            };
        }
    }
}
