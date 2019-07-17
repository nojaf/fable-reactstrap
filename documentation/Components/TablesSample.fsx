#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Tables.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private tablesSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "TablesSample")

exportDefault tablesSample
