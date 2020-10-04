#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Pagination.fs"
#load "../../src/PaginationItem.fs"
#load "../../src/PaginationLink.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let a = Pagination.pagination

let private paginationSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            fragment [] [
                Pagination.pagination [] [
                    PaginationItem.paginationItem [] [
                        PaginationLink.paginationLink [ PaginationLink.First true
                                                        PaginationLink.Custom [ Href "#" ] ] []
                    ]
                    PaginationItem.paginationItem [] [
                        PaginationLink.paginationLink [ PaginationLink.Previous true
                                                        PaginationLink.Custom [ Href "#" ] ] []
                    ]
                    PaginationItem.paginationItem [] [
                        PaginationLink.paginationLink [ PaginationLink.Custom [ Href "#" ] ] [
                            str "1"
                        ]
                    ]
                    PaginationItem.paginationItem [] [
                        PaginationLink.paginationLink [ PaginationLink.Custom [ Href "#" ] ] [
                            str "2"
                        ]
                    ]
                    PaginationItem.paginationItem [] [
                        PaginationLink.paginationLink [ PaginationLink.Custom [ Href "#" ] ] [
                            str "3"
                        ]
                    ]
                    PaginationItem.paginationItem [] [
                        PaginationLink.paginationLink [ PaginationLink.Custom [ Href "#" ] ] [
                            str "4"
                        ]
                    ]
                    PaginationItem.paginationItem [] [
                        PaginationLink.paginationLink [ PaginationLink.Custom [ Href "#" ] ] [
                            str "5"
                        ]
                    ]
                    PaginationItem.paginationItem [] [
                        PaginationLink.paginationLink [ PaginationLink.Next true
                                                        PaginationLink.Custom [ Href "#" ] ] []
                    ]
                    PaginationItem.paginationItem [] [
                        PaginationLink.paginationLink [ PaginationLink.Last true
                                                        PaginationLink.Custom [ Href "#" ] ] []
                    ]
                ]
            ]),
         "PaginationSample")

exportDefault paginationSample
