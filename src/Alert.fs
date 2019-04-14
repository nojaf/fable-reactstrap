namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Alert =
    
    type AlertProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("cssModule")>] CSSModule of Common.CSSModule
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("transition")>] Transition of TransitionProps
        | [<CompiledName("isOpen")>] IsOpen of bool
        | [<CompiledName("toggle")>] Toggle of (unit -> unit)
        
    
    let alert (props: AlertProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Alert" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems