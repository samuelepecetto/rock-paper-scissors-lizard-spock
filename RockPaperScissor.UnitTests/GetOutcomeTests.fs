module GetOutcomeTests

open RockPaperScissors.RockPaperScissors
open Xunit

// --------- Win ---------

// Scissors cuts Paper
[<Fact>]
let ``Scissors vs Paper should result in Win`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Scissors Sign.Paper with
    | GameResult.Win(_) -> Assert.True(true)
    | _ -> Assert.True(false)

// Paper covers Rock
[<Fact>]
let ``Paper vs Rock should result in Win`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Paper Sign.Rock with
    | GameResult.Win(_) -> Assert.True(true)
    | _ -> Assert.True(false)

// Rock crushes Lizard
[<Fact>]
let ``Rock vs Lizard should result in Win`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Rock Sign.Lizard with
    | GameResult.Win(_) -> Assert.True(true)
    | _ -> Assert.True(false)

// Lizard poisons Spock
[<Fact>]
let ``Lizard vs Spock should result in Win`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Lizard Sign.Spock with
    | GameResult.Win(_) -> Assert.True(true)
    | _ -> Assert.True(false)

// Spock smashes Scissors
[<Fact>]
let ``Spock vs Scissors should result in Win`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Spock Sign.Scissors with
    | GameResult.Win(_) -> Assert.True(true)
    | _ -> Assert.True(false)

// Scissors decapitates Lizard
[<Fact>]
let ``Scissors vs Lizard should result in Win`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Scissors Sign.Lizard with
    | GameResult.Win(_) -> Assert.True(true)
    | _ -> Assert.True(false)

// Lizard eats Paper
[<Fact>]
let ``Lizard vs Paper should result in Win`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Lizard Sign.Paper with
    | GameResult.Win(_) -> Assert.True(true)
    | _ -> Assert.True(false)

// Paper disproves Spock
[<Fact>]
let ``Paper vs Spock should result in Win`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Paper Sign.Spock with
    | GameResult.Win(_) -> Assert.True(true)
    | _ -> Assert.True(false)

// Spock vaporizes Rock
[<Fact>]
let ``Spock vs Rock should result in Win`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Spock Sign.Rock with
    | GameResult.Win(_) -> Assert.True(true)
    | _ -> Assert.True(false)

// and as it always has Rock crushes Scissors
[<Fact>]
let ``Rock vs Scissors should result in Win`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Rock Sign.Scissors with
    | GameResult.Win(_) -> Assert.True(true)
    | _ -> Assert.True(false)

// --------- Draws ---------
[<Fact>]
let ``Rock vs Rock should result in Draw`` () =
    let scoreBoard = ScoreBoard()
    let result = scoreBoard.PlayGame Sign.Rock Sign.Rock
    Assert.Equal(GameResult.Draw, result)

[<Fact>]
let ``Paper vs Paper should result in Draw`` () =
    let scoreBoard = ScoreBoard()
    let result = scoreBoard.PlayGame Sign.Paper Sign.Paper
    Assert.Equal(GameResult.Draw, result)

[<Fact>]
let ``Scissors vs Scissors should result in Draw`` () =
    let scoreBoard = ScoreBoard()
    let result = scoreBoard.PlayGame Sign.Scissors Sign.Scissors
    Assert.Equal(GameResult.Draw, result)

[<Fact>]
let ``Lizard vs Lizard should result in Draw`` () =
    let scoreBoard = ScoreBoard()
    let result = scoreBoard.PlayGame Sign.Lizard Sign.Lizard
    Assert.Equal(GameResult.Draw, result)

[<Fact>]
let ``Spock vs Spock should result in Draw`` () =
    let scoreBoard = ScoreBoard()
    let result = scoreBoard.PlayGame Sign.Spock Sign.Spock
    Assert.Equal(GameResult.Draw, result)

// --------- GameResult.Loss ---------
[<Fact>]
let ``Rock vs Paper should result in Loss`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Rock Sign.Paper with
    | GameResult.Loss(_) -> Assert.True(true)
    | _ -> Assert.True(false)

[<Fact>]
let ``Paper vs Scissors should result in Loss`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Paper Sign.Scissors with
    | GameResult.Loss(_) -> Assert.True(true)
    | _ -> Assert.True(false)

[<Fact>]
let ``Scissors vs Rock should result in Loss`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Scissors Sign.Rock with
    | GameResult.Loss(_) -> Assert.True(true)
    | _ -> Assert.True(false)

[<Fact>]
let ``Paper vs Lizard should result in Loss`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Paper Sign.Lizard with
    | GameResult.Loss(_) -> Assert.True(true)
    | _ -> Assert.True(false)

[<Fact>]
let ``Spock vs Lizard should result in Loss`` () =
    let scoreBoard = ScoreBoard()

    match scoreBoard.PlayGame Sign.Spock Sign.Lizard with
    | GameResult.Loss(_) -> Assert.True(true)
    | _ -> Assert.True(false)
