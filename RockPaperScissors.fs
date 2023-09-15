module RockPaperScissors =

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
        
    let getOutcome (sign1: Sign) (sign2: Sign) : Outcome =
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
        | Spock, Rock -> Outcome.Player1Wins

        | Scissors, Rock
        | Lizard, Scissors
        | Spock, Lizard
        | Scissors, Spock
        | Paper, Scissors
        | Rock, Paper
        | Lizard, Rock
        | Paper, Lizard
        | Spock, Paper
        | Rock, Spock -> Outcome.Player2Wins

        | _ -> Outcome.Draw