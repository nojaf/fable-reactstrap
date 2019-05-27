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
    
    let mkCol size =
        { size = size; order = !^0; offset = !^ 0 }
        
    let withOffset offset col =
        { col with offset = offset }
        
    let withOrder order col =
        { col with order = order }

    type ColProps =
        | ClassName of string
        | Tag of string
        | Xs of ColumnProps
        | Sm of ColumnProps
        | Md of ColumnProps
        | Lg of ColumnProps
        | Xl of ColumnProps
        | Widths of obj array

    let col (props: ColProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Col" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems