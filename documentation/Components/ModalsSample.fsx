#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Modals.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private modalsSample =
    FunctionComponent.Of<obj> (fun _ ->
        fragment [] [
        ]
    , "ModalsSample")
    
exportDefault modalsSample