namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Container =

    type ContainerProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("fluid")>] Fluid of bool

    let container (props: ContainerProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Container" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems