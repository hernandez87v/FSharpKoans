namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// About Strings
//
// Most languages have a set of utilities for manipulating 
// strings. F# is no different.
//---------------------------------------------------------------
[<Koan(Sort = 7)>]
module ``about strings`` =

    [<Koan>]
    let StringValue() =
        let message = "hello"

        AssertEquality message

    [<Koan>]
    let StringConcatValue() =
        let message = "hello " + "world"
        
        AssertEquality message

    [<Koan>]
    let FormattingStringValues() =
        let message = sprintf "F# turns it to %d!" 11
        
        AssertEquality message

        //NOTE: you can use printf to print to standard output

        (* TRY IT: What happens if you change 11 to be something besides 
                   a number? *)

    [<Koan>]
    let FormattingOtherTypes() =
        let message = sprintf "hello %s" "world"
        
        AssertEquality message

    [<Koan>]
    let FormattingAnything() =
        let message = sprintf "Formatting other types is as easy as: %A" (1, 2, 3)
        
        AssertEquality message

    (* NOTE: For all the %formatters that you can use with string formatting 
             see: https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/plaintext-formatting *)

    [<Koan>]
    let CombineMultiline() =
        let message = "super\
                        cali\
                        fragilistic\
                        expiali\
                        docious"
        
        AssertEquality message

    [<Koan>]
    let Multiline() =
        let message = "This
                        is
                        on
                        five
                        lines"

        AssertEquality
              message

    [<Koan>]
    let ExtractValues() =
        let message = "hello world"

        let first = message.[0]
        let other = message.[4] 

 (* A single character is denoted using single quotes, example: 'c',
        not double quotes as you would use for a string *)
           
        AssertEquality first
        AssertEquality other

    [<Koan>]
    let ApplyWhatYouLearned() =
        (* It's time to apply what you've learned so far. Fill in the function below to
           make the asserts pass *)
        let getFunFacts x =
            

        let funFactsAboutThree = getFunFacts 3
        let funFactsAboutSix = getFunFacts 6

        AssertEquality "3 doubled is 6, and 3 tripled is 9!" funFactsAboutThree 
        AssertEquality "6 doubled is 12, and 6 tripled is 18!" funFactsAboutSix 
