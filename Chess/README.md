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
    - Player.Init(int time)
    - Player.Move(string move)
    - Player.Resign()
    - Player.OfferDraw()
    - Player.AcceptDraw()
    - Player.LoseOnTime()
