namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Form =

    type FormProps =
        | [<CompiledName("className")>] ClassName of string

    let form (props: FormProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Form" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems