#load "../.paket/load/netstandard2.0/main.group.fsx"

open Fable.React
open Fable.Core.JsInterop

let prismCode sourceCode =
    let props =
        createObj [
            "component" ==> "pre"
            "className" ==> "language-fsharp"
        ]
        
    let elems = Seq.singleton (str sourceCode)
    ofImport "PrismCode" "react-prism" props elems