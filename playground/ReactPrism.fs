module ReactPrism

open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<Emit("require($0)")>]
let require path = jsNative

let prismCode path =
    let raw : string = require (sprintf "!!raw-loader!%s" path)
    let props =
        createObj [
            "component" ==> "pre"
            "className" ==> "language-fsharp"
        ]
        
    let elems = Seq.singleton (str raw)
    ofImport "PrismCode" "react-prism" props elems