namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Pagination =

    type PaginationProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("listClassName")>] ListClassName of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("size")>] Size of Common.Size
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("listTag")>] ListTag of string
        | [<CompiledName("aria-label")>] AriaLabel of string

    let pagination (props: PaginationProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Pagination" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems