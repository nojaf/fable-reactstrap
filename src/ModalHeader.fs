namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ModalHeader =

    type ModalHeaderProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("wrapTag")>] WrapTag of string
        | [<CompiledName("toggle")>] Toggle of string

    let modalHeader (props: ModalHeaderProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ModalHeader" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems