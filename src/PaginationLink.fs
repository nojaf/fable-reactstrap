namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module PaginationLink =

    type PaginationLinkProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("key")>] Key of obj
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("next")>] Next of bool
        | [<CompiledName("previous")>] Previous of bool
        | [<CompiledName("first")>] First of bool
        | [<CompiledName("last")>] Last of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("aria-label")>] AriaLabel of string

    let paginationLink (props: PaginationLinkProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "PaginationLink" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems