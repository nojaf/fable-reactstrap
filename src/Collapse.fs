namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Collapse =

    type CollapseProps =
        | [<CompiledName("in")>] In of bool
        | [<CompiledName("baseClass")>] BaseClass of string
        | [<CompiledName("baseClassIn")>] BaseClassIn of string
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("transitionAppearTimeout")>] TransitionAppearTimeout of int
        | [<CompiledName("transitionEnterTimeout")>] TransitionEnterTimeout of int
        | [<CompiledName("transitionLeaveTimeout")>] TransitionLeaveTimeout of int
        | [<CompiledName("transitionAppear")>] TransitionAppear of bool
        | [<CompiledName("transitionEnter")>] TransitionEnter of bool
        | [<CompiledName("transitionLeave")>] TransitionLeave of bool
        | [<CompiledName("onLeave")>] OnLeave of (unit -> unit)
        | [<CompiledName("onEnter")>] OnEnter of (unit -> unit)
        | [<CompiledName("isOpen")>] IsOpen of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("innerRef")>] InnerRef of (Element -> unit)
        | [<CompiledName("navbar")>] Navbar of bool
        | [<CompiledName("onEntering")>] OnEntering of (unit -> unit)
        | [<CompiledName("onEntered")>] OnEntered of (unit -> unit)
        | [<CompiledName("onExiting")>] OnExiting of (unit -> unit)
        | [<CompiledName("onExited")>] OnExited of (unit -> unit)

    let collapse (props: CollapseProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Collapse" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems