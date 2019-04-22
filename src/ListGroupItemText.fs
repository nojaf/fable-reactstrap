namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ListGroupItemText =

    type ListGroupItemTextProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let listGroupItemText (props: ListGroupItemTextProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ListGroupItemText" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems