namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module CarouselCaption =

    type CarouselCaptionProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("captionHeader")>] CaptionHeader of string
        | [<CompiledName("captionText")>] CaptionText of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let carouselCaption (props: CarouselCaptionProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CarouselCaption" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems