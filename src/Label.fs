namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Label =

    type LabelProps =
        | [<CompiledName("className")>] ClassName of string

    let label (props: LabelProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Label" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems