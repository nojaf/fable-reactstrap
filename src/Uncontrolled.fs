namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Uncontrolled =

    type UncontrolledProps =
        | [<CompiledName("className")>] ClassName of string

    let uncontrolled (props: UncontrolledProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Uncontrolled" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems