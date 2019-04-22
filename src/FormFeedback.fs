namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module FormFeedback =

    type FormFeedbackProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("valid")>] Valid of bool
        | [<CompiledName("tooltip")>] Tooltip of bool
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("tag")>] Tag of string

    let formFeedback (props: FormFeedbackProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "FormFeedback" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems