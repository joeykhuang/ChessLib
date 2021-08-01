using Xunit;
using ChessLib;

namespace ChessTest
{
    public class TestBoard
    {
        [Fact]
        public void TestBoardInit()
        {
            var testBoard = new Board();
            testBoard.Init();

            var boardPositions = testBoard.BoardPositions;
            for (int row = 0; row < 7; row++)
            { 
                for (int column = 0; column < 7; column++)
                {
                    Assert.Equal(boardPositions[row, column].GetPosition(),
                                 row + "," + column);
		        }			    
	        }
        }

        [Fact]
        public void TestBoardClear()
        {
            var testBoard = new Board();
            testBoard.Init();

            testBoard.Clear();
            var boardPositions = testBoard.BoardPositions;
            for (int row = 0; row < 7; row++)
            { 
                for (int column = 0; column < 7; column++)
                {
                    Assert.Equal(boardPositions[row, column].SquarePiece,
                                new Square(row, column).SquarePiece);
		        }			    
	        }
	    }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 2)]
        [InlineData(3, 7)]
        [InlineData(7, 7)]
        public void TestWithinBoard_ShouldTrue(int row, int column)
        {
            var position = (row, column);
            Assert.True(Board.WithinBoard(position));
	    }

        [Theory]
        [InlineData(-1, 3)]
        [InlineData(4, 8)]
        [InlineData(7, 9)]
        [InlineData(9, 10)]
        public void TestWithinBoard_ShouldFalse(int row, int column)
        {
            var position = (row, column);
            Assert.False(Board.WithinBoard(position));
	    }
    }
}
