#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Pagination.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private paginationSample = FunctionComponent.Of<obj>((fun _ -> fragment [] []), "PaginationSample")

exportDefault paginationSample
