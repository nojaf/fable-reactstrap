#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Form.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private formSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "FormSample")

exportDefault formSample
