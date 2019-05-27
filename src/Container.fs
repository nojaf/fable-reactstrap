namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module Container =

    type ContainerProps =
        | ClassName of string
        | Fluid of bool
        | Tag of string

    let container (props: ContainerProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Container" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems