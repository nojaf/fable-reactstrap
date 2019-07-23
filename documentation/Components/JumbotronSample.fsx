#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Jumbotron.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private jumbotronSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "JumbotronSample")

exportDefault jumbotronSample
