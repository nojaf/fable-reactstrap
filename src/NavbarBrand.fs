namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module NavbarBrand =

    type NavbarBrandProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string

    let navbarBrand (props: NavbarBrandProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "NavbarBrand" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems