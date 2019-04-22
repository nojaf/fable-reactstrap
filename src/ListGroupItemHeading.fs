namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ListGroupItemHeading =

    type ListGroupItemHeadingProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let listGroupItemHeading (props: ListGroupItemHeadingProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ListGroupItemHeading" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems