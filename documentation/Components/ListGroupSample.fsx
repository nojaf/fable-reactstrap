#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/ListGroup.fs"
#load "../../src/ListGroupItem.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private listGroupSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            ListGroup.listGroup [] [
                ListGroupItem.listGroupItem [] [
                    str "Cras justo odio"
                ]
                ListGroupItem.listGroupItem [] [
                    str "Dapibus ac facilisis in"
                ]
                ListGroupItem.listGroupItem [] [
                    str "Morbi leo risus"
                ]
                ListGroupItem.listGroupItem [] [
                    str "Porta ac consectetur ac"
                ]
                ListGroupItem.listGroupItem [] [
                    str "Vestibulum at eros"
                ]
            ]),
         "ListGroupSample")

exportDefault listGroupSample
