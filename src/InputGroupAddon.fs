namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module InputGroupAddon =

    type InputGroupAddonProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("addonType")>] AddonType of Common.AddonType

    let inputGroupAddon (props: InputGroupAddonProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "InputGroupAddon" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems