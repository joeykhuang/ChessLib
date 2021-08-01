using System;
using System.Collections.Generic;
namespace ChessLib.Pieces
{
    public class Queen : Piece
    {
        public Queen(bool color, Square square) : base(color, square)
        {
            base.Moves = new List<(int, int)>()
            {
                // Horizontal moves
                (0, 1),
                (0, 2),
                (0, 3),
                (0, 4),
                (0, 5),
                (0, 6),
                (0, 7),

                // Vertical moves
                (1, 0),
                (2, 0),
                (3, 0),
                (4, 0),
                (5, 0),
                (6, 0),
                (7, 0),

                // Diagonal moves
                (1, 1),
                (2, 2),
                (3, 3),
                (4, 4),
                (5, 5),
                (6, 6),
                (7, 7)
            };
        }
    }
}
