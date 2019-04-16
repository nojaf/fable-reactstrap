namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardGroup =
    
    type CardGroupProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        
    let cardGroup (props: CardGroupProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardGroup" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems