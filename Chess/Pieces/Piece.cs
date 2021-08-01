using System;
using System.Collections.Generic;
namespace ChessLib.Pieces
{
    public abstract class Piece
    {
        public virtual List<(int, int)> Moves { get; protected set; }

        public bool Color
        { get; }

        public Square CurrentSquare
        { get; }

        public Piece (bool color, Square currentSquare)
        {
            Color = color;
            CurrentSquare = currentSquare;
	    }

        private List<(int, int)> AlterMoves((int, int) availableMove)
        {
            var horizontal = availableMove.Item1;
            var vertical = availableMove.Item2;

            return new List<(int, int)>() {
                (horizontal, vertical),
			    (-horizontal, vertical),
			    (horizontal, -vertical),
			    (-horizontal, -vertical)
	        };

	    }

        public virtual List<(int, int)> AllowedMovePositions()
	    {
            var movePositions = new List<(int, int)>();
            foreach ((int, int) availableMove in Moves)
            { 
                foreach ((int, int) moveOption in AlterMoves(availableMove))
                {
                    var newPosition = (CurrentSquare.Row + moveOption.Item1, 
			                           CurrentSquare.Column + moveOption.Item2);
                    if (Board.WithinBoard(newPosition))
                    {
                        movePositions.Add(newPosition);
		            }
				}
	        }
            return movePositions;
	    }
    }
}
