namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module ListGroupItem =

    type ListGroupItemProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("key")>] Key of obj
        | [<CompiledName("active")>] Active of bool
        | [<CompiledName("disabled")>] Disabled of bool
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("action")>] Action of bool
        | [<CompiledName("href")>] Href of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("onClick")>] OnClick of (MouseEvent -> unit)

    let listGroupItem (props: ListGroupItemProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "ListGroupItem" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems