using System.Collections.Generic;
namespace ChessLib
{
    public class Player
    {
        private bool _color;
        private bool _isInCheck; // Whether the player is currently in check

        public int Score { get; protected set; }
        public List<Pieces.Piece> BoardPieces;
        public List<Pieces.Piece> TakenPieces;

        public Player()
        {
            BoardPieces = new List<Pieces.Piece>();
            TakenPieces = new List<Pieces.Piece>();
        }

        public void Init(Board gameBoard, bool color)
        {
            _color = color;
            Score = 0;
            foreach (Square eachSquare in gameBoard.BoardPositions)
            { 
                if (eachSquare.SquarePiece.Color == _color)
                {
                    BoardPieces.Add(eachSquare.SquarePiece);
		        }
	        }
	    }

        public string GetSide()
        {
            if (_color) return "White";
            else return "Black";
	    }

        public void OfferDraw()
        { 
	    }

        public void AcceptDraw()
        { 
	    }

        public void Resign()
        { 
	    }

        public void Move(string move)
        {
            try
            { 
		        var piece, square = ParseMove(move); 
	        }
	    }

        public void LoseOnTime()
        { 
	    }
    }
}
