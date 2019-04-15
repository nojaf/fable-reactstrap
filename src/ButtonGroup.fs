namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ButtonGroup =
    type ButtonGroupProps =
        | [<CompiledName("aria-label")>] AriaLabel of string
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("role")>] Role of string
        | [<CompiledName("size")>] Size of Common.Size
        | [<CompiledName("vertical")>] Vertical of bool
        
    let buttonGroup (props: ButtonGroupProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ButtonGroup" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems


