#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Badge.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private badgeSample =
    FunctionComponent.Of<obj>(fun _ ->
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
        ]
    , "BadgeSample")

exportDefault badgeSample