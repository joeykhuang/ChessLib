using System.Collections.Generic;
namespace ChessLib.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(bool color, Square square) : base(color, square)
        {
            base.Moves = new List<(int, int)>()
            {
                (1, 0)
            };
        }

        public override List<(int, int)> AllowedMovePositions()
        {
            var movePositions = new List<(int, int)>();
            if (Color)
            {
                if (CurrentSquare.Row == 1)
                {
                    movePositions.Add((3, CurrentSquare.Column));
		        }
		        movePositions.Add((CurrentSquare.Row + 1, CurrentSquare.Column));
	        }
	        else
	        { 
                if (CurrentSquare.Row == 7)
                {
                    movePositions.Add((5, CurrentSquare.Column));
		        }
                movePositions.Add((CurrentSquare.Row - 1, CurrentSquare.Column));
	        }

            return movePositions;
	    }

    }
}
