namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Popover =

    type PopoverProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("trigger")>] Trigger of string
        | [<CompiledName("isOpen")>] IsOpen of bool
        | [<CompiledName("toggle")>] Toggle of (unit -> unit)
        | [<CompiledName("boundariesElement")>] BoundariesElement of U2<string, Element>
        | [<CompiledName("target")>] Target of U2<string,Element>
        | [<CompiledName("container")>] Container of U2<string,Element>
        | [<CompiledName("innerClassName")>] InnerClassName of string
        | [<CompiledName("disabled")>] Disabled of bool
        | [<CompiledName("hideArrow")>] HideArrow of bool
        | [<CompiledName("placementPrefix")>] PlacementPrefix of string
        | [<CompiledName("delay")>] Delay of Common.Delay
        | [<CompiledName("placement")>] Placement of Common.Placement
        | [<CompiledName("modifiers")>] Modifiers of obj
        | [<CompiledName("offset")>] Offset of U2<string, int>
        | [<CompiledName("fade")>] Fade of bool
        | [<CompiledName("flip")>] Flip of bool

    let popover (props: PopoverProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Popover" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems