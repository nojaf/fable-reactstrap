namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardDeck =
    
    type CardDeckProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        
    let cardDeck (props: CardDeckProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardDeck" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems

