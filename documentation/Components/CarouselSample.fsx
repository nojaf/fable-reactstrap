#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Carousel.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private carouselSample =
    FunctionComponent.Of<obj> (fun _ ->
        fragment [] [
        ]
    , "CarouselSample")
    
exportDefault carouselSample