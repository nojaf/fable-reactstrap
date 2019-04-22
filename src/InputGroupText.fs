namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module InputGroupText =

    type InputGroupTextProps =
        | [<CompiledName("className")>] ClassName of string

    let inputGroupText (props: InputGroupTextProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "InputGroupText" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems