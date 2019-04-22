namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Fade =

    type FadeProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("in")>] In of bool
        | [<CompiledName("mountOnEnter")>] MountOnEnter of bool
        | [<CompiledName("unmountOnExit")>] UnmountOnExit of bool
        | [<CompiledName("appear")>] Appear of bool
        | [<CompiledName("enter")>] Enter of bool
        | [<CompiledName("exit")>] Exit of bool
        | [<CompiledName("timeout")>] Timeout of U2<int, {|enter:int;exit:int|}>
        | [<CompiledName("addEndListener")>] AddEndListener of (string -> (Event -> unit))
        | [<CompiledName("onEnter")>] OnEnter of (unit -> unit)
        | [<CompiledName("onEntering")>] OnEntering of (unit -> unit)
        | [<CompiledName("onEntered")>] OnEntered of (unit -> unit)
        | [<CompiledName("onExit")>] OnExit of (unit -> unit)
        | [<CompiledName("onExiting")>] OnExiting of (unit -> unit)
        | [<CompiledName("onExited")>] OnExited of (unit -> unit)
        | [<CompiledName("baseClass")>] BaseClass of string

    let fade (props: FadeProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Fade" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems