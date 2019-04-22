namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Carousel =

    type CarouselProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("activeIndex")>] ActiveIndex of int
        | [<CompiledName("next")>] Next of (unit -> unit)
        | [<CompiledName("previous")>] Previous of (unit -> unit)
        | [<CompiledName("keyboard")>] Keyboard of bool
        | [<CompiledName("pause")>] Pause of U2<string, bool>
        | [<CompiledName("ride")>] Ride of string
        | [<CompiledName("interval")>] Interval of U3<int,string,bool>
        | [<CompiledName("mouseEnter")>] MouseEnter of (MouseEvent -> unit)
        | [<CompiledName("mouseLeave")>] MouseLeave of (MouseEvent -> unit)
        | [<CompiledName("slide")>] Slide of bool
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let carousel (props: CarouselProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Carousel" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems