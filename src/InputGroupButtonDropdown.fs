namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module InputGroupButtonDropdown =

    type InputGroupButtonDropdownProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("addonType")>] AddonType of Common.AddonType
        | [<CompiledName("groupClassName")>] GroupClassName of string
        | [<CompiledName("groupAttributes")>] GroupAttributes of obj

    let inputGroupButtonDropdown (props: InputGroupButtonDropdownProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "InputGroupButtonDropdown" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems