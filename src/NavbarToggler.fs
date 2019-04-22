namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module NavbarToggler =

    type NavbarTogglerProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("type")>] Type of string
        | [<CompiledName("tag")>] Tag of string

    let navbarToggler (props: NavbarTogglerProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "NavbarToggler" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems