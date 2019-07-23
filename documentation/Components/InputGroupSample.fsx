#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/InputGroup.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private inputGroupSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "InputGroupSample")

exportDefault inputGroupSample
