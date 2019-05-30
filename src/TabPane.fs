namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap
open Fable.React.Props

[<RequireQualifiedAccess>]
module TabPane =

    type TabPaneProps =
        | Tag of U2<string, obj>
        | TabId of U2<string,int>
        | CssModule of CSSModule
        | Custom of HTMLAttr list

    let tabPane (props: TabPaneProps seq) (elems: ReactElement seq) : ReactElement =
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
        ofImport "TabPane" "reactstrap" props elems