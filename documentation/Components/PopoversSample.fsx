#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Popovers.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private popoversSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "PopoversSample")

exportDefault popoversSample
