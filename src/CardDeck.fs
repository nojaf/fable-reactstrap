namespace Reactstrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module CardDeck =

    type CardDeckProps =
        | Tag of U2<string, obj>
        | Custom of IHTMLProp list


    let cardDeck (props: CardDeckProps seq) (elems: ReactElement seq): ReactElement =
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

        let props = JS.Constructors.Object.assign (createEmpty, customProps, typeProps)
        ofImport "CardDeck" "reactstrap" props elems
