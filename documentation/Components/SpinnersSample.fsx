#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Spinners.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private spinnersSample =
    FunctionComponent.Of<obj> (fun _ ->
        fragment [] [
        ]
    , "SpinnersSample")
    
exportDefault spinnersSample