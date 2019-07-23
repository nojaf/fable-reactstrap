#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Dropdowns.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private dropdownsSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "DropdownsSample")

exportDefault dropdownsSample
