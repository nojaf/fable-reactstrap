#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Toasts.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private toastsSample =
    FunctionComponent.Of<obj> (fun _ ->
        fragment [] [
        ]
    , "ToastsSample")
    
exportDefault toastsSample