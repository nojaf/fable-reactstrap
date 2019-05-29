#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Navbar.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private navbarSample =
    FunctionComponent.Of<obj> (fun _ ->
        fragment [] [
        ]
    , "NavbarSample")
    
exportDefault navbarSample