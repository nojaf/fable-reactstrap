#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Badge.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private badgeSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            fragment [] [
                h3 [] [
                    str "Heading "
                    Badge.badge [ Badge.Color Secondary ] [
                        str "New"
                    ]
                ]
                Badge.badge [ Badge.Color Warning ] [
                    str "oh my"
                ]
                Badge.badge [ Badge.Color Dark
                              Badge.Custom([ ClassName "ml-1" ]) ] [
                    str "dark"
                ]
                Badge.badge [ Badge.Custom([ ClassName "ml-1" ]) ] [
                    str "badges"
                ]
                div [] [
                    Badge.badge [ Badge.Color Info; Badge.Pill ] [
                        str "pill"
                    ]
                ]
                div [] [
                    Badge.badge [ Badge.Color Danger
                                  Badge.Custom
                                      ([ Href "https://nojaf.com"
                                         Target "_blank" ]) ] [
                        str "with link"
                    ]
                ]
            ]),
         "BadgeSample")

exportDefault badgeSample
