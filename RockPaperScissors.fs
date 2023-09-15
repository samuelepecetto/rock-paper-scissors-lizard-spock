module RockPaperScissors =
    type GameResult =
        | Win of int  // Player 1 wins with a value indicating the number of wins
        | Loss of int // Player 2 wins with a value indicating the number of wins
        | Draw
        
    type Outcome =
        | Player1Wins
        | Player2Wins
        | Draw

    type Sign =
        | Rock
        | Paper
        | Scissors
        | Lizard
        | Spock
        
    type ScoreBoard() =
        let mutable player1Score = 0
        let mutable player2Score = 0

        member this.Player1Score = player1Score
        member this.Player2Score = player2Score

        member this.PlayGame (sign1: Sign) (sign2: Sign) : GameResult =
            match sign1, sign2 with
            | Rock, Scissors
            | Scissors, Lizard
            | Lizard, Spock
            | Spock, Scissors
            | Scissors, Paper
            | Paper, Rock
            | Rock, Lizard
            | Lizard, Paper
            | Paper, Spock
            | Spock, Rock ->
                player1Score <- player1Score + 1
                GameResult.Win(player1Score)


            | Scissors, Rock
            | Lizard, Scissors
            | Spock, Lizard
            | Scissors, Spock
            | Paper, Scissors
            | Rock, Paper
            | Lizard, Rock
            | Paper, Lizard
            | Spock, Paper
            | Rock, Spock -> 
                player2Score <- player2Score + 1
                GameResult.Loss(player2Score)

            | _ -> GameResult.Draw