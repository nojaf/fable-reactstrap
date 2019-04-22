namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module CustomInput =

    type CustomInputProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("inline")>] Inline of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("innerRef")>] InnerRef of (Element -> unit)
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let customInput (props: CustomInputProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CustomInput" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems