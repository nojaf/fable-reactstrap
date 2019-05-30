namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap
open Fable.React.Props

[<RequireQualifiedAccess>]
module CarouselIndicators =

    type CarouselIndicatorsProps =
        | Items of obj array
        | ActiveIndex of int
        | CssModule of CSSModule
        | OnClickHandler of (MouseEvent -> unit)
        | Custom of HTMLAttr list

    let carouselIndicators (props: CarouselIndicatorsProps seq) (elems: ReactElement seq) : ReactElement =
        let customProps =
            props
            |> Seq.collect (function
                | Custom props -> props
                | _ -> List.empty)
            |> keyValueList CaseRules.LowerFirst

        let typeProps =
            props
            |> Seq.choose (function
                | Custom _ -> None
                | prop -> Some prop)
            |> keyValueList CaseRules.LowerFirst

        let props = JS.Object.assign (createEmpty, customProps, typeProps)
        ofImport "CarouselIndicators" "reactstrap" props elems