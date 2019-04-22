namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module PaginationItem =

    type PaginationItemProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("key")>] Key of obj
        | [<CompiledName("active")>] Active of bool
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("disabled")>] Disabled of bool
        | [<CompiledName("tag")>] Tag of string

    let paginationItem (props: PaginationItemProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "PaginationItem" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems