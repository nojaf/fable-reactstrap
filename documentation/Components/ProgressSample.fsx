#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Progress.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private progressSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "ProgressSample")

exportDefault progressSample
