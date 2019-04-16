namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module Card =
    
    type CardProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("inverse")>] Inverse of bool
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("body")>] Body of bool
        | [<CompiledName("className")>] ClassName of string
        
    let card (props: CardProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Card" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems

