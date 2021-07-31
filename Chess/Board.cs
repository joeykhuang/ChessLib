using System;
namespace ChessLib
{
    public class Board
    {

        public Square[,] BoardPositions
        { get; set; }

        /// <summary>
        ///     Initializes the Chess Board and place both sides' pieces on their respective positions
        /// </summary>
        public void Init()
        {
            BoardPositions = new Square[8, 8];

            // Initializes the squares on the Board
            for (int row = 0; row < 8; row++)
            { 
                for (int column = 0; column < 8; column++)
                {
                    BoardPositions[row, column] = new Square(row, column);
		        }
	        }


            // Setup board pieces
            for (int row = 0; row <= 7; row += 7)
            {
                var color = row < 4; // Is white if on the lower side of the board
			    for (int col = 0; col < 8; col++) {
					BoardPositions[Math.Abs(row - 6), col].SquarePiece = new Pieces.Pawn(color);
				}

			    BoardPositions[row, 0].SquarePiece = new Pieces.Rook(color);
			    BoardPositions[row, 1].SquarePiece = new Pieces.Knight(color);
			    BoardPositions[row, 2].SquarePiece = new Pieces.Bishop(color);
			    BoardPositions[row, 3].SquarePiece = new Pieces.Queen(color);
			    BoardPositions[row, 4].SquarePiece = new Pieces.King(color);
			    BoardPositions[row, 5].SquarePiece = new Pieces.Bishop(color);
			    BoardPositions[row, 6].SquarePiece = new Pieces.Knight(color);
			    BoardPositions[row, 7].SquarePiece = new Pieces.Rook(color);
	        }
        }

        /// <summary>
        ///     Clears the Chess Board and resets all the Squares on the Board
        /// </summary>
        public void Clear()
        {
            for (int row = 0; row < 8; row++)
            { 
                for (int column = 0; column < 8; column++)
                {
                    BoardPositions[row, column] = new Square(row, column);
		        }
	        }
	    }

    }
}
