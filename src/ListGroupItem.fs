namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap
open Fable.React.Props

[<RequireQualifiedAccess>]
module ListGroupItem =

    type ListGroupItemProps =
        | Active of bool
        | Disabled of bool
        | Color of Common.Color
        | Action of bool
        | CssModule of CSSModule
        | Tag of U2<string, obj>
        | Custom of HTMLAttr list
        

    let listGroupItem (props: ListGroupItemProps seq) (elems: ReactElement seq) : ReactElement =
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
        ofImport "ListGroupItem" "reactstrap" props elems