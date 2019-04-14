namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module BreadcrumbItem =
    
    type BreadcrumbItemProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("active")>] Active
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("cssModule")>] CSSModule of Common.CSSModule
        | [<CompiledName("href")>] Href of string
        
    let breadcrumbItem (props: BreadcrumbItemProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "BreadcrumbItem" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems

