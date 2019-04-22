namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Table =

    type TableProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("size")>] Size of Common.Size
        | [<CompiledName("bordered")>] Bordered of bool
        | [<CompiledName("borderless")>] Borderless of bool
        | [<CompiledName("striped")>] Striped of bool
        | [<CompiledName("dark")>] Dark of bool
        | [<CompiledName("hover")>] Hover of bool
        | [<CompiledName("responsive")>] Responsive of bool
        | [<CompiledName("innerRef")>] InnerRef of (Element -> unit)

    let table (props: TableProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Table" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems