#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Media.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private mediaSample =
    FunctionComponent.Of<obj> (fun _ ->
        fragment [] [
        ]
    , "MediaSample")
    
exportDefault mediaSample