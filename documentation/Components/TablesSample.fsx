#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Table.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private tablesSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            Table.table [] [
                thead [] [
                    tr [] [
                        th [] [ str "#" ]
                        th [] [ str "First Name" ]
                        th [] [ str "Last Name" ]
                        th [] [ str "Username" ]
                    ]
                ]
                tbody [] [
                    tr [] [
                        th [ HTMLAttr.Scope "row" ] [ str "1" ]
                        td [] [ str "Mark" ]
                        td [] [ str "Otto" ]
                        td [] [ str "@mdo" ]
                    ]
                    tr [] [
                        th [ HTMLAttr.Scope "row" ] [ str "2" ]
                        td [] [ str "Jacob" ]
                        td [] [ str "Thornton" ]
                        td [] [ str "@fat" ]
                    ]
                    tr [] [
                        th [ HTMLAttr.Scope "row" ] [ str "3" ]
                        td [] [ str "Larry" ]
                        td [] [ str "the Bird" ]
                        td [] [ str "@twitter" ]
                    ]
                ]
            ]),
         "TablesSample")

exportDefault tablesSample
