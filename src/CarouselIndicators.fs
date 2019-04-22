namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module CarouselIndicators =

    type CarouselIndicatorsProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("items")>] Items of obj array
        | [<CompiledName("activeIndex")>] ActiveIndex of int
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("onClickHandler")>] OnClickHandler of (MouseEvent -> unit)

    let carouselIndicators (props: CarouselIndicatorsProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CarouselIndicators" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems