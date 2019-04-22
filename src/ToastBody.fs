namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ToastBody =

    type ToastBodyProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("innerRef")>] InnerRef of (Element -> unit)

    let toastBody (props: ToastBodyProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ToastBody" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems