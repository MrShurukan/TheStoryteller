namespace TheStorytellerCompiler
open System
open FParsec

module SampleTests =
    type Token = Empty | Hello
    let fparsec_test =
        let emptyParser = pstring " " >>% Token.Empty
        let helloParser = pstringCI "привет" >>% Token.Hello
        
        let p = emptyParser <|> helloParser
        
        let result = run p "привет!"
        
        printfn $"%O{result}"
        printfn "Done testing."
        
module Parser =
    