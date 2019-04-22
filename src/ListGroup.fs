namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ListGroup =

    type ListGroupProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("flush")>] Flush of bool
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let listGroup (props: ListGroupProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ListGroup" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems