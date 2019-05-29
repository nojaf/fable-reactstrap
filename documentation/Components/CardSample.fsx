#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Card.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private cardSample =
    FunctionComponent.Of<obj> (fun _ ->
        fragment [] [
        ]
    , "CardSample")
    
exportDefault cardSample