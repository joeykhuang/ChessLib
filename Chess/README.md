# Chess Library

## Classes:
    - Game
    - Board
    - Player
    - Piece
        - Pawn
        - Knight
        - Rook
        - Bishop
        - Queen
        - King
    - Move

## Interfaces

    **Game:**
    - Game.Init(Player p1, Player p2)
    - Game.End()
    - Game.Summary()

    **Player:**
    - Player.Move(string move)
    - Player.Resign()
    - Player.OfferDraw()
    - Player.AcceptDraw()
    - Player.LoseOnTime()


## Game Progression


- player1 = new Player()
- player2 = new Player()
- game = Game.Init(player1, player2)
    - board = new Board()
    - player1Color = randomColor()
    - player1.Init(board, player1Color)
    - player2.Init(board, !player1Color)
- While(!game.End()) {
    - Player1.Act()
        - Player1.OfferDraw()
        - Player1.AcceptDraw()
        - Player1.Resign()
        - Player1.Move()
        - Player1.LoseOnTime()
    - Player2.Act()
        - Player2.OfferDraw()
        - Player2.AcceptDraw()
        - Player2.Resign()
        - Player2.Move()
        - Player2.LoseOnTime()
  }
- Game.Summary()