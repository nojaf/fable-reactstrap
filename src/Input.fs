namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Input =

    type InputProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("type")>] Type of string
        | [<CompiledName("size")>] Size of Common.Size
        | [<CompiledName("bsSize")>] BsSize of Common.Size
        | [<CompiledName("valid")>] Valid of bool
        | [<CompiledName("invalid")>] Invalid of bool
        | [<CompiledName("plaintext")>] Plaintext of string
        | [<CompiledName("addon")>] Addon of bool
        | [<CompiledName("innerRef")>] InnerRef of (Element -> unit)
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("tag")>] Tag of string

    let input (props: InputProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Input" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems