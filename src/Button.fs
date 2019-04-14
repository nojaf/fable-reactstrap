namespace ReactStrap

namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Button =
    
    type ButtonProps =
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("outline")>] Outline of bool
        | [<CompiledName("active")>] Active of bool
        | [<CompiledName("block")>] Block of bool
        | [<CompiledName("disabled")>] Disabled of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("innerRef")>] InnerRef of IRefHook<Element option>
        | [<CompiledName("onClick")>] OnClick of (MouseEvent -> unit)
        | [<CompiledName("size")>] Size of Common.Size
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("cssModule")>] CSSModule of Common.CSSModule
        | [<CompiledName("close")>] Close of bool

    let button (props: ButtonProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Button" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems