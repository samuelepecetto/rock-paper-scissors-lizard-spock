module GetOutcomeTests

open RockPaperScissors.RockPaperScissors
open Xunit
open RockPaperScissors

type GetOutcomeTests() =
    // --------- Player1Wins ---------
    
    // Scissors cuts Paper
    [<Fact>]
    member this.``Scissors vs Paper should result in Player1Wins``() =
        let result = getOutcome Sign.Scissors Sign.Paper
        Assert.Equal(Outcome.Player1Wins, result)

    // Paper covers Rock
    [<Fact>]
    member this.``Paper vs Rock should result in Player1Wins``() =
        let result = getOutcome Sign.Paper Sign.Rock
        Assert.Equal(Outcome.Player1Wins, result)

    // Rock crushes Lizard
    [<Fact>]
    member this.``Rock vs Lizard should result in Player1Wins``() =
        let result = getOutcome Sign.Rock Sign.Lizard
        Assert.Equal(Outcome.Player1Wins, result)

    // Lizard poisons Spock
    [<Fact>]
    member this.``Lizard vs Spock should result in Player1Wins``() =
        let result = getOutcome Sign.Lizard Sign.Spock
        Assert.Equal(Outcome.Player1Wins, result)

    // Spock smashes Scissors
    [<Fact>]
    member this.``Spock vs Scissors should result in Player1Wins``() =
        let result = getOutcome Sign.Spock Sign.Scissors
        Assert.Equal(Outcome.Player1Wins, result)

    // Scissors decapitates Lizard
    [<Fact>]
    member this.``Scissors vs Lizard should result in Player1Wins``() =
        let result = getOutcome Sign.Scissors Sign.Lizard
        Assert.Equal(Outcome.Player1Wins, result)

    // Lizard eats Paper
    [<Fact>]
    member this.``Lizard vs Paper should result in Player1Wins``() =
        let result = getOutcome Sign.Lizard Sign.Paper
        Assert.Equal(Outcome.Player1Wins, result)

    // Paper disproves Spock
    [<Fact>]
    member this.``Paper vs Spock should result in Player1Wins``() =
        let result = getOutcome Sign.Paper Sign.Spock
        Assert.Equal(Outcome.Player1Wins, result)

    // Spock vaporizes Rock
    [<Fact>]
    member this.``Spock vs Rock should result in Player1Wins``() =
        let result = getOutcome Sign.Spock Sign.Rock
        Assert.Equal(Outcome.Player1Wins, result)

    // and as it always has Rock crushes Scissors
    [<Fact>]
    member this.``Rock vs Scissors should result in Player1Wins``() =
        let result = getOutcome Sign.Rock Sign.Scissors
        Assert.Equal(Outcome.Player1Wins, result)



    // --------- Draws ---------
    [<Fact>]
    member this.``Rock vs Rock should result in Draw``() =
        let result = getOutcome Sign.Rock Sign.Rock
        Assert.Equal(Outcome.Draw, result)

    [<Fact>]
    member this.``Paper vs Paper should result in Draw``() =
        let result = getOutcome Sign.Paper Sign.Paper
        Assert.Equal(Outcome.Draw, result)

    [<Fact>]
    member this.``Scissors vs Scissors should result in Draw``() =
        let result = getOutcome Sign.Scissors Sign.Scissors
        Assert.Equal(Outcome.Draw, result)

    [<Fact>]
    member this.``Lizard vs Lizard should result in Draw``() =
        let result = getOutcome Sign.Lizard Sign.Lizard
        Assert.Equal(Outcome.Draw, result)

    [<Fact>]
    member this.``Spock vs Spock should result in Draw``() =
        let result = getOutcome Sign.Spock Sign.Spock
        Assert.Equal(Outcome.Draw, result)

    // --------- Player2Wins ---------

    [<Fact>]
    member this.``Rock vs Paper should result in Player2Wins``() =
        let result = getOutcome Sign.Rock Sign.Paper
        Assert.Equal(Outcome.Player2Wins, result)
    
    [<Fact>]
    member this.``Paper vs Scissors should result in Player2Wins``() =
        let result = getOutcome Sign.Paper Sign.Scissors
        Assert.Equal(Outcome.Player2Wins, result)
    
    [<Fact>]
    member this.``Scissors vs Rock should result in Player2Wins``() =
        let result = getOutcome Sign.Scissors Sign.Rock
        Assert.Equal(Outcome.Player2Wins, result)
    
    [<Fact>]
    member this.``Paper vs Lizard should result in Player2Wins``() =
        let result = getOutcome Sign.Paper Sign.Lizard
        Assert.Equal(Outcome.Player2Wins, result)
    
    [<Fact>]
    member this.``Spock vs Lizard should result in Player2Wins``() =
        let result = getOutcome Sign.Spock Sign.Lizard
        Assert.Equal(Outcome.Player2Wins, result)
    
