namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardHeader =
    
    type CardHeaderProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        
    let cardHeader (props: CardHeaderProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardHeader" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems