namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Progress =

    type ProgressProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("multi")>] Multi of bool
        | [<CompiledName("bar")>] Bar of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("value")>] Value of U2<string,int>
        | [<CompiledName("max")>] Max of U2<string,int>
        | [<CompiledName("animated")>] Animated of bool
        | [<CompiledName("striped")>] Striped of bool
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("barClassName")>] BarClassName of string

    let progress (props: ProgressProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Progress" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems