namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module NavLink =

    type NavLinkProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("disabled")>] Disabled of bool
        | [<CompiledName("active")>] Active of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("innerRef")>] InnerRef of (Element -> unit)

    let navLink (props: NavLinkProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "NavLink" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems