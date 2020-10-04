#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Container.fs"
#load "../../src/Row.fs"
#load "../../src/Col.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private layoutSample =
    let customLayout =
        Col.mkCol !^6
        |> Col.withOrder !^2
        |> Col.withOffset !^1

    let customLayout1 = Col.mkCol !^6 |> Col.withOffset !^3

    let customLayout2 =
        Col.mkCol !^ "auto" |> Col.withOffset !^1

    FunctionComponent.Of<obj>
        ((fun _ ->
            fragment [] [
                Container.container [] [
                    Row.row [] [ Col.col [] [ str ".col" ] ]
                    Row.row [] [
                        Col.col [] [ str ".col" ]
                        Col.col [] [ str ".col" ]
                        Col.col [] [ str ".col" ]
                        Col.col [] [ str ".Col.col" ]
                    ]
                    Row.row [] [
                        Col.col [ Col.Xs(Col.mkCol !^3) ] [
                            str ".col-3"
                        ]
                        Col.col [ Col.Xs(Col.mkCol !^ "auto") ] [
                            str ".col-auto - variable width content"
                        ]
                        Col.col [ Col.Xs(Col.mkCol !^3) ] [
                            str ".col-3"
                        ]
                    ]
                    Row.row [] [
                        Col.col [ Col.Xs(Col.mkCol !^6) ] [
                            str ".col-6"
                        ]
                        Col.col [ Col.Xs(Col.mkCol !^6) ] [
                            str ".col-6"
                        ]
                    ]
                    Row.row [] [
                        Col.col [ Col.Xs(Col.mkCol !^6)
                                  Col.Sm(Col.mkCol !^4) ] [
                            str ".col-6 .col-sm-4"
                        ]
                        Col.col [ Col.Xs(Col.mkCol !^6)
                                  Col.Sm(Col.mkCol !^4) ] [
                            str ".col-6 .col-sm-4"
                        ]
                        Col.col [ Col.Sm(Col.mkCol !^4) ] [
                            str ".col-sm-4"
                        ]
                    ]
                    Row.row [] [
                        Col.col [ Col.Sm customLayout ] [
                            str ".col-sm-6 .order-sm-2 .offset-sm-1"
                        ]
                    ]
                    Row.row [] [
                        Col.col [ Col.Md customLayout1
                                  Col.Sm(Col.mkCol !^12) ] [
                            str ".col-sm-12 .col-md-6 .offset-md-3"
                        ]
                    ]
                    Row.row [] [
                        Col.col [ Col.Sm customLayout2 ] [
                            str ".col-sm-auto .offset-sm-1"
                        ]
                        Col.col [ Col.Sm customLayout2 ] [
                            str ".col-sm-auto .offset-sm-1"
                        ]
                    ]
                ]
            ]),
         "LayoutSample")

exportDefault layoutSample
