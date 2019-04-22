namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module PopoverBody =

    type PopoverBodyProps =
        | [<CompiledName("className")>] ClassName of string

    let popoverBody (props: PopoverBodyProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "PopoverBody" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems