module Playground.Components.BreadcrumbsSample

open Fable.React
open Fable.React.Props
open ReactStrap
open ReactPrism

let breadcrumbsSample =
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
        prismCode """open Fable.React
open Fable.React.Props
open ReactStrap

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
"""
    ]