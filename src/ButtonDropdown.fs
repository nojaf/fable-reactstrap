namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ButtonDropdown =
    
    type ButtonDropdownProps =
        | [<CompiledName("disabled")>] Disabled of bool
        | [<CompiledName("direction")>] Direction of Common.Direction
        | [<CompiledName("group")>] Group of bool
        | [<CompiledName("isOpen")>] IsOpen of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("toggle")>] Toggle of (unit -> unit)

    let buttonDropdown (props: ButtonDropdownProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ButtonDropdown" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems
