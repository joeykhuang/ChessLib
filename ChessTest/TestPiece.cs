using Xunit;
using System.Collections.Generic;
using ChessLib.Pieces;
using System.Linq;

namespace ChessTest
{
    public class TestPieceMovePositions
    {

        [Fact]
        public void TestAllMovePosition_Pawn_InitWhite()
        {
            var testPawn = new Pawn(true, new ChessLib.Square(1, 2));

            var allowedPositions = testPawn.AllowedMovePositions();

            Assert.True(allowedPositions.All(new List<(int, int)>()
            {
                (2, 2),
                (3, 2)
            }.Contains));
	    }
        
        [Fact]
        public void TestAllMovePosition_Pawn_InitBlack()
        {
            var testPawn = new Pawn(false, new ChessLib.Square(7, 5));

            var allowedPositions = testPawn.AllowedMovePositions();

            Assert.True(allowedPositions.All(new List<(int, int)>()
            {
                (6, 5),
                (5, 5)
            }.Contains));
	    }

        [Fact]
        public void TestAllMovePosition_Pawn_White()
        {
            var testPawn = new Pawn(true, new ChessLib.Square(4, 7));

            var allowedPositions = testPawn.AllowedMovePositions();

            Assert.True(allowedPositions.All(new List<(int, int)>()
            {
                (5, 7),
            }.Contains));
	    }

        [Fact]
        public void TestAllowedMovePositions_Bishop()
        {
            var testBishop = new Bishop(true, new ChessLib.Square(0, 3));

            var allowedPositions = testBishop.AllowedMovePositions();

            Assert.True(allowedPositions.All(new List<(int, int)>()
	        {
                (1, 4),
                (2, 5),
                (3, 6),
                (4, 7),

                (1, 2),
                (2, 1),
                (3, 0)
            }.Contains));
        }

        [Fact]
        public void TestAllowedMovePositions_Knight()
        {
            var testKnight = new Knight(true, new ChessLib.Square(4, 3));

            var allowedPositions = testKnight.AllowedMovePositions();

            Assert.True(allowedPositions.All(new List<(int, int)>()
	        {
                (6, 4),
                (6, 2),

                (5, 5),
                (5, 1),

                (2, 4),
                (2, 2),

                (3, 5),
                (3, 1)
            }.Contains));
        }

        [Fact]
        public void TestAllowedMovePositions_Rook()
        { 
            var testRook = new Rook(true, new ChessLib.Square(5, 6));

            var allowedPositions = testRook.AllowedMovePositions();

            Assert.True(allowedPositions.All(new List<(int, int)>()
	        {
                // Horizontal
                (5, 0),
                (5, 1),
                (5, 2),
                (5, 3),
                (5, 4),
                (5, 5),
                (5, 7),

                // Vertical
                (0, 6),
                (1, 6),
                (2, 6),
                (3, 6),
                (4, 6),
                (6, 6),
                (7, 6),
            }.Contains));

	    }

        [Fact]
        public void TestAllowedMovePositions_Queen()
        { 
            var testQueen = new Queen(true, new ChessLib.Square(5, 6));

            var allowedPositions = testQueen.AllowedMovePositions();

            Assert.True(allowedPositions.All(new List<(int, int)>()
	        {
                // Horizontal
                (5, 0),
                (5, 1),
                (5, 2),
                (5, 3),
                (5, 4),
                (5, 5),
                (5, 7),

                // Vertical
                (0, 6),
                (1, 6),
                (2, 6),
                (3, 6),
                (4, 6),
                (6, 6),
                (7, 6),

                // Diagonals 
                (6, 7),
                (4, 5),
                (3, 4),
                (2, 3),
                (1, 2),
                (0, 1),
                (4, 7),
                (6, 5),
                (7, 4)
            }.Contains));
	    }

        [Fact]
        public void TestAllowedMovePositions_King()
        {
            var testKing = new King(true, new ChessLib.Square(2, 3));

            var allowedPositions = testKing.AllowedMovePositions();

            Assert.True(allowedPositions.All(new List<(int, int)>()
	        {
                (1, 3),
                (3, 3),

                (2, 2),
                (2, 4),

                (3, 2),
                (3, 4),

                (1, 2),
                (1, 4)
            }.Contains));
        }
    }
}
