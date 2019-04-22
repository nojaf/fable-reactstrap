namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Col =
    type ColumnProps = {
        size: U3<bool, int, string>
        order: U2<string, int>
        offset: U2<string, int>
    }

    type ColProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("xs")>] Xs of ColumnProps
        | [<CompiledName("sm")>] Sm of ColumnProps
        | [<CompiledName("md")>] Md of ColumnProps
        | [<CompiledName("lg")>] Lg of ColumnProps
        | [<CompiledName("xl")>] Xl of ColumnProps
        | [<CompiledName("widths")>] Widths of obj array

    let col (props: ColProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Col" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems