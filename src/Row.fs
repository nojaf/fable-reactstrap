namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Row =

    type RowProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("noGutters")>] NoGutters of bool
        | [<CompiledName("form")>] Form of bool

    let row (props: RowProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Row" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems