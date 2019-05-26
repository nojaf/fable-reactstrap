module Playground.Components.BadgeSample

open Fable.React
open ReactStrap
open ReactPrism

let badgeSample =
    fragment [] [
        h3 []
            [ str "Heading "
              Badge.badge [ Badge.Color Secondary ] [ str "New" ] ]
        Badge.badge [ Badge.Color Warning ] [ str "oh my" ]
        Badge.badge
            [ Badge.Color Dark
              Badge.ClassName "ml-1" ] [ str "dark" ]
        Badge.badge [ Badge.ClassName "ml-1" ] [ str "badges" ]
        div []
            [ Badge.badge
                [ Badge.Color Info
                  Badge.Pill ] [ str "pill" ] ]
        div []
            [ Badge.badge
                [ Badge.Color Danger
                  Badge.Href "https://nojaf.com" ] [ str "with link" ] ]
        prismCode """open Fable.React
open ReactStrap

h3 []
    [ str "Heading "
      Badge.badge [ Badge.Color Secondary ] [ str "New" ] ]
Badge.badge [ Badge.Color Warning ] [ str "oh my" ]
Badge.badge
    [ Badge.Color Dark
      Badge.ClassName "ml-1" ] [ str "dark" ]
Badge.badge [ Badge.ClassName "ml-1" ] [ str "badges" ]
div []
    [ Badge.badge
        [ Badge.Color Info
          Badge.Pill ] [ str "pill" ] ]
div []
    [ Badge.badge
        [ Badge.Color Danger
          Badge.Href "https://nojaf.com" ] [ str "with link" ] ]
"""
    ]

