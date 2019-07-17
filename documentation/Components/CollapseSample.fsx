#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Collapse.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private collapseSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "CollapseSample")

exportDefault collapseSample
