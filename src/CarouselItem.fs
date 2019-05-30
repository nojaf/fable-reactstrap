namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open ReactStrap

[<RequireQualifiedAccess>]
module CarouselItem =
    type CarouselItemProps =
        | In of bool
        | BaseClass of string
        | BaseClassIn of string
        | CssModule of CSSModule
        | TransitionAppearTimeout of int
        | TransitionEnterTimeout of int
        | TransitionLeaveTimeout of int
        | TransitionAppear of bool
        | TransitionEnter of bool
        | TransitionLeave of bool
        | OnLeave of (unit -> unit)
        | OnEnter of (unit -> unit)
        | Slide of bool
        | Tag of U2<string, obj>
        | Custom of HTMLAttr list

    let carouselItem (props: CarouselItemProps seq) (elems: ReactElement seq): ReactElement =
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
        ofImport "CarouselItem" "reactstrap" props elems
