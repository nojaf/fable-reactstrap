namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Spinner =

    type SpinnerProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("type")>] Type of string
        | [<CompiledName("size")>] Size of Common.Size
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let spinner (props: SpinnerProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Spinner" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems