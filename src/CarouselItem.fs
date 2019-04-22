namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module CarouselItem =

    type CarouselItemProps =
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
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("slide")>] Slide of bool

    let carouselItem (props: CarouselItemProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CarouselItem" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems