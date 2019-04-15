namespace ReactStrap

open Fable.Core

[<AutoOpen>]
module Common =
    [<StringEnum>]
    type Color =
        | [<CompiledName("primary")>] Primary
        | [<CompiledName("secondary")>] Secondary
        | [<CompiledName("success")>] Success
        | [<CompiledName("danger")>] Danger
        | [<CompiledName("warning")>] Warning
        | [<CompiledName("info")>] Info
        | [<CompiledName("light")>] Light
        | [<CompiledName("dark")>] Dark
        | [<CompiledName("link")>] Link
        
    type [<AllowNullLiteral>] CSSModule =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: className: string -> string with get, set

    type TransitionProps =
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
        
    [<StringEnum>]
    type Size =
        | [<CompiledName("lg")>] Lg
        | [<CompiledName("sm")>] Sm
        | [<CompiledName("md")>] Md
        | [<CompiledName("xs")>] Xs

    [<StringEnum>]
    type Direction =
        | [<CompiledName("up")>] Up
        | [<CompiledName("down")>] Down
        | [<CompiledName("left")>] Left
        | [<CompiledName("right")>] Right