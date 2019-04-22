namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module FormGroup =

    type FormGroupProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("row")>] Row of bool
        | [<CompiledName("check")>] Check of bool
        | [<CompiledName("inline")>] Inline of bool
        | [<CompiledName("disabled")>] Disabled of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let formGroup (props: FormGroupProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "FormGroup" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems