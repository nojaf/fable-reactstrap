#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Container.fs"
#load "../../src/Row.fs"
#load "../../src/Col.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let container = Container.container
let row = Row.row
let col = Col.col
let custom  attr =
    attr
    |> Col.Custom

let private layoutSample =
    let customLayout =
        {|
            size = 6;
            order = 2;
            offset = 1;
        |}

    let customLayout1 =
        {|
            size = 6;
            offset = 3;
        |}
    let customLayout2 =
        {|
            size = "auto";
            offset = 1;
        |}

    FunctionComponent.Of<obj>
        ((fun _ -> fragment [] [
            container [ ]
                [ row [ ]
                    [ col [ ] [str ".col" ]]
                  row [ ]
                    [ col [ ] [str ".col"]
                      col [ ] [str ".col"]
                      col [ ] [str ".col"]
                      col [ ] [str ".col"] ]
                  row [ ]
                    [ col [ custom [ HTMLAttr.Custom("xs","3")] ]
                        [str ".col-3"]
                      col [ custom [ HTMLAttr.Custom("xs", "auto") ] ]
                        [str ".col-auto - variable width content"]
                      col [ custom [ HTMLAttr.Custom("xs", "3") ] ]
                        [str ".col-3" ] ]
                  row [ ]
                    [ col [ custom [HTMLAttr.Custom ("xs", "6") ] ]
                        [str ".col-6"]
                      col [ custom [HTMLAttr.Custom ("xs", "6") ] ]
                        [str ".col-6"] ]
                  row [ ]
                    [ col [ custom [HTMLAttr.Custom ("xs", "6")
                                    HTMLAttr.Custom ("sm", "4")  ] ]
                        [ str ".col-6 .col-sm-4"]
                      col [ custom [HTMLAttr.Custom ("xs", "6")
                                    HTMLAttr.Custom ("sm", "4") ] ]
                        [str ".col-6 .col-sm-4"]
                      col [custom  [HTMLAttr.Custom ("sm", "4") ] ]
                        [str ".col-sm-4" ] ]
                  row [ ]
                    [ col [ custom  [
                            HTMLAttr.Custom ("sm", customLayout) ] ]
                        [ str ".col-sm-6 .order-sm-2 .offset-sm-1"]
                     ]
                  row [ ]
                    [ col [ custom [
                            HTMLAttr.Custom ("md", customLayout1)
                            HTMLAttr.Custom ("sm", "12") ] ]
                        [ str ".col-sm-12 .col-md-6 .offset-md-3" ]
                    ]
                  row [ ]
                    [ col [ custom [ HTMLAttr.Custom ("sm", customLayout2) ] ]
                        [str ".col-sm-auto .offset-sm-1"]
                      col [ custom [ HTMLAttr.Custom ("sm", customLayout2) ] ]
                        [str ".col-sm-auto .offset-sm-1"]
                    ]
                ]
        ])
        , "LayoutSample")

exportDefault layoutSample
