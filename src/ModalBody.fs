namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ModalBody =

    type ModalBodyProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let modalBody (props: ModalBodyProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ModalBody" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems