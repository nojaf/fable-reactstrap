namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardText =
    
    type CardTextProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        
    let cardText (props: CardTextProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardText" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems



