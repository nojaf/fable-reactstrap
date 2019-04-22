namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Jumbotron =

    type JumbotronProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("fluid")>] Fluid of bool
        | [<CompiledName("tag")>] Tag of string

    let jumbotron (props: JumbotronProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Jumbotron" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems