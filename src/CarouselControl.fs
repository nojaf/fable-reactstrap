namespace ReactStrap

open Browser.Types
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module CarouselControl =

    type CarouselControlProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("direction")>] Direction of Common.Direction
        | [<CompiledName("onClickHandler")>] OnClickHandler of (MouseEvent -> unit)
        | [<CompiledName("directionText")>] DirectionText of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let carouselControl (props: CarouselControlProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CarouselControl" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems