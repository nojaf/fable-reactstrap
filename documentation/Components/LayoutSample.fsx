#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Layout.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private layoutSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "LayoutSample")

exportDefault layoutSample
