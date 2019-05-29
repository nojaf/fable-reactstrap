#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Tooltips.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private tooltipsSample =
    FunctionComponent.Of<obj> (fun _ ->
        fragment [] [
        ]
    , "TooltipsSample")
    
exportDefault tooltipsSample