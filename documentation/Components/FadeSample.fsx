#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Fade.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private fadeSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "FadeSample")

exportDefault fadeSample
