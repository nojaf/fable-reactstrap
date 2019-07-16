namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap
open Fable.React.Props

[<RequireQualifiedAccess>]
module InputGroup =

    type InputGroupProps =
        | Size of Common.Size
        | Tag of U2<string, obj>
        | Custom of IHTMLProp list

    let inputGroup (props: InputGroupProps seq) (elems: ReactElement seq) : ReactElement =
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
        ofImport "InputGroup" "reactstrap" props elems