namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module DropdownMenu =

    type DropdownMenuProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("right")>] Right of bool
        | [<CompiledName("flip")>] Flip of bool
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("cssModule")>] CssModule of Common.CSSModule
        | [<CompiledName("modifiers")>] Modifiers of obj
        | [<CompiledName("persist")>] Persist of bool
        
    let dropdownMenu (props: DropdownMenuProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "DropdownMenu" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems