namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module PopoverHeader =

    type PopoverHeaderProps =
        | [<CompiledName("className")>] ClassName of string

    let popoverHeader (props: PopoverHeaderProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "PopoverHeader" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems