#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/ListGroup.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private listGroupSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "ListGroupSample")

exportDefault listGroupSample
