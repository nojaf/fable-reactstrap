namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ButtonToolbar =
    
    type ButtonToolbarProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("aria-label")>] AriaLabel of string
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("role")>] Role of string
        | [<CompiledName("cssModule")>] CSSModule of Common.CSSModule
        
    let buttonToolbar (props: ButtonToolbarProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ButtonToolbar" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems


