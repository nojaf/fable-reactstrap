namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Breadcrumb =
    type BreadcrumbProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("listTag")>] ListTag of string
        | [<CompiledName("listClassName")>] ListClassName of string
        | [<CompiledName("cssModule")>] CSSModule of Common.CSSModule
        
    let breadcrumb (props: BreadcrumbProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Breadcrumb" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems