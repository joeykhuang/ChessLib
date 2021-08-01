using System;
using System.Collections.Generic;
namespace ChessLib.Pieces
{
    public class Rook : Piece
    {
        public Rook(bool color, Square square) : base(color, square)
        {
            base.Moves = new List<(int, int)>()
            {
                (0, 1),
                (0, 2),
                (0, 3),
                (0, 4),
                (0, 5),
                (0, 6),
                (0, 7),
                (1, 0),
                (2, 0),
                (3, 0),
                (4, 0),
                (5, 0),
                (6, 0),
                (7, 0)
            };
        }
    }
}
