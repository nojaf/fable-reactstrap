namespace Reactstrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Reactstrap
open Fable.React.Props

[<RequireQualifiedAccess>]
module Input =

    type InputProps =
        | Size of Common.Size
        | BsSize of Common.Size
        | Valid of bool
        | Invalid of bool
        | Plaintext of string
        | Addon of bool
        | InnerRef of (Element -> unit)
        | CssModule of CSSModule
        | Tag of U2<string, obj>
        | Custom of IHTMLProp list

    let input (props: InputProps seq) (elems: ReactElement seq): ReactElement =
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
        ofImport "Input" "reactstrap" props elems
