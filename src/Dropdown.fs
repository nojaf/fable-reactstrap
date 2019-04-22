namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Dropdown =

    type DropdownProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("disabled")>] Disabled of bool
        | [<CompiledName("direction")>] Direction of Common.Direction
        | [<CompiledName("group")>] Group of bool
        | [<CompiledName("isOpen")>] IsOpen of bool
        | [<CompiledName("nav")>] Nav of bool
        | [<CompiledName("active")>] Active of bool
        | [<CompiledName("inNavbar")>] InNavbar of bool
        | [<CompiledName("toggle")>] Toggle of (unit -> unit)
        | [<CompiledName("setActiveFromChild")>] SetActiveFromChild of bool

    let dropdown (props: DropdownProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Dropdown" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems