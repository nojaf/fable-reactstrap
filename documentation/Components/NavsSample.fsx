#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Navs.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private navsSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "NavsSample")

exportDefault navsSample
