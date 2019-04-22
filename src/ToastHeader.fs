namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ToastHeader =

    type ToastHeaderProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("wrapTag")>] WrapTag of string
        | [<CompiledName("toggle")>] Toggle of (unit -> unit)
        | [<CompiledName("icon")>] Icon of U2<string, ReactElement>
        | [<CompiledName("close")>] Close of ReactElement
        | [<CompiledName("charCode")>] CharCode of U2<string, int>
        | [<CompiledName("closeAriaLabel")>] CloseAriaLabel of string

    let toastHeader (props: ToastHeaderProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ToastHeader" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems