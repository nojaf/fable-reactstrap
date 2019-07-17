namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap
open Fable.React.Props

[<RequireQualifiedAccess>]
module ButtonGroup =
    type ButtonGroupProps =
        | AriaLabel of string
        | Role of string
        | Size of Common.Size
        | Vertical of bool
        | Custom of IHTMLProp list

    let buttonGroup (props: ButtonGroupProps seq) (elems: ReactElement seq): ReactElement =
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

        ofImport "ButtonGroup" "reactstrap" props elems
