namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module DropdownItem =

    type DropdownItemProps =
        | [<CompiledName("active")>] Active of bool
        | [<CompiledName("disabled")>] Disabled of bool
        | [<CompiledName("divider")>] Divider of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("header")>] Header of bool
        | [<CompiledName("onClick")>] OnClick of (MouseEvent -> unit)
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("cssModule")>] CssModule of Common.CSSModule
        | [<CompiledName("toggle")>] Toggle of bool
        
    let dropdownItem (props: DropdownItemProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "DropdownItem" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems