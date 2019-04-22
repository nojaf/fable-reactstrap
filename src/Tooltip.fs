namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Tooltip =

    type TooltipProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("trigger")>] Trigger of string
        | [<CompiledName("boundariesElement")>] BoundariesElement of U2<string,Element>
        | [<CompiledName("isOpen")>] IsOpen of bool
        | [<CompiledName("hideArrow")>] HideArrow of bool
        | [<CompiledName("toggle")>] Toggle of (unit -> unit)
        | [<CompiledName("target")>] Target of U2<string, Element>
        | [<CompiledName("container")>] Container of U2<string,Element>
        | [<CompiledName("delay")>] Delay of Common.Delay
        | [<CompiledName("innerClassName")>] InnerClassName of string
        | [<CompiledName("arrowClassName")>] ArrowClassName of string
        | [<CompiledName("autohide")>] Autohide of bool
        | [<CompiledName("placement")>] Placement of Common.Placement
        | [<CompiledName("modifiers")>] Modifiers of obj
        | [<CompiledName("offset")>] Offset of U2<string,int>
        | [<CompiledName("innerRef")>] InnerRef of (Element -> unit)
        | [<CompiledName("fade")>] Fade of bool
        | [<CompiledName("flip")>] Flip of bool

    let tooltip (props: TooltipProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Tooltip" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems