#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Breadcrumb.fs"
#load "../../src/BreadcrumbItem.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open ReactStrap

let private breadcrumbsSample =
    FunctionComponent.Of(fun () ->
        fragment [] [
            Breadcrumb.breadcrumb []
                [ BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Active true ]
                      [ str "Home" ] ]
            Breadcrumb.breadcrumb []
                [ BreadcrumbItem.breadcrumbItem [] [ a [ Href "#" ] [ str "Home" ] ]
            
                  BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Active true ]
                      [ str "Library" ] ]
            Breadcrumb.breadcrumb []
                [ BreadcrumbItem.breadcrumbItem [] [ a [ Href "#" ] [ str "Home" ] ]
                  BreadcrumbItem.breadcrumbItem [] [ a [ Href "#" ] [ str "Library" ] ]
            
                  BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Active true ]
                      [ str "Data" ] ]
            p [] [ str "No list" ]
            Breadcrumb.breadcrumb
                [ Breadcrumb.Tag "nav"
                  Breadcrumb.ListTag "div" ]
                [ BreadcrumbItem.breadcrumbItem
                    [ BreadcrumbItem.Tag "a"
                      BreadcrumbItem.Href "#" ] [ str "Home" ]
                  BreadcrumbItem.breadcrumbItem
                      [ BreadcrumbItem.Tag "a"
                        BreadcrumbItem.Href "#" ] [ str "Library" ]
                  BreadcrumbItem.breadcrumbItem
                      [ BreadcrumbItem.Tag "a"
                        BreadcrumbItem.Href "#" ] [ str "Data" ]
                  BreadcrumbItem.breadcrumbItem
                      [ BreadcrumbItem.Tag "span"
                        BreadcrumbItem.Active true ] [ str "Bootstrap" ] ]
        ]
    )

exportDefault breadcrumbsSample