namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap
open Fable.React.Props

[<RequireQualifiedAccess>]
module DropdownItem =

    type DropdownItemProps =
        | Active of bool
        | Disabled of bool
        | Divider of bool
        | Header of bool
        | CssModule of Common.CSSModule
        | Toggle of bool
        | Tag of U2<string, obj>
        | Custom of HTMLAttr list
        
    let dropdownItem (props: DropdownItemProps seq) (elems: ReactElement seq) : ReactElement =
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
        ofImport "DropdownItem" "reactstrap" props elems