namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module DropdownToggle =

    type DropdownToggleProps =
        | [<CompiledName("caret")>] Caret of bool
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("disabled")>] Disabled of bool
        | [<CompiledName("onClick")>] OnClick of (MouseEvent -> unit)
        | [<CompiledName("data-toggle")>] DataToggle of string
        | [<CompiledName("aria-haspopup")>] AriaHasPopup of bool
        
    let dropdownToggle (props: DropdownToggleProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "DropdownToggle" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems
