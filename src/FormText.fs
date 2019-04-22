namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module FormText =

    type FormTextProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("inline")>] Inline of bool
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let formText (props: FormTextProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "FormText" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems