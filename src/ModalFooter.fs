namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ModalFooter =

    type ModalFooterProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let modalFooter (props: ModalFooterProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ModalFooter" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems