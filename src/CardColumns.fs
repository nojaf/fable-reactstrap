namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardColumns =
    
    type CardColumnsProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        
    let cardColumns (props: CardColumnsProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardColumns" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems

