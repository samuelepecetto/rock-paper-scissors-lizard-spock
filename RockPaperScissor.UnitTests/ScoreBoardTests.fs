module RockPaperScissor.UnitTests.ScoreBoardTests

open RockPaperScissors.RockPaperScissors
open Xunit

[<Fact>]
let ``Player1 wins, score should be 1-0`` () =
    let scoreBoard = ScoreBoard()
    let gameResult = scoreBoard.PlayGame Sign.Rock Sign.Scissors
    Assert.Equal(GameResult.Win(1), gameResult)
    Assert.Equal(1, scoreBoard.Player1Score)
    Assert.Equal(0, scoreBoard.Player2Score)

[<Fact>]
let ``Player2 wins, score should be 0-1`` () =
    let scoreBoard = ScoreBoard()
    let gameResult = scoreBoard.PlayGame Sign.Scissors Sign.Rock
    Assert.Equal(GameResult.Loss(1), gameResult)
    Assert.Equal(0, scoreBoard.Player1Score)
    Assert.Equal(1, scoreBoard.Player2Score)

[<Fact>]
let ``Draw, score should remain 0-0`` () =
    let scoreBoard = ScoreBoard()
    let gameResult = scoreBoard.PlayGame Sign.Rock Sign.Rock
    Assert.Equal(GameResult.Draw, gameResult)
    Assert.Equal(0, scoreBoard.Player1Score)
    Assert.Equal(0, scoreBoard.Player2Score)

[<Fact>]
let ``Multiple games, score should accumulate correctly`` () =
    let scoreBoard = ScoreBoard()
    scoreBoard.PlayGame Sign.Rock Sign.Scissors
    scoreBoard.PlayGame Sign.Paper Sign.Rock
    scoreBoard.PlayGame Sign.Scissors Sign.Scissors
    Assert.Equal(2, scoreBoard.Player1Score)
    Assert.Equal(0, scoreBoard.Player2Score)
