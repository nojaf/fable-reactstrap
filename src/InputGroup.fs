namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module InputGroup =

    type InputGroupProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("size")>] Size of Common.Size

    let inputGroup (props: InputGroupProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "InputGroup" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems