namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module NavItem =

    type NavItemProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("active")>] Active of bool
        | [<CompiledName("tag")>] Tag of string

    let navItem (props: NavItemProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "NavItem" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems