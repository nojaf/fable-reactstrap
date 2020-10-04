#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Nav.fs"
#load "../../src/NavItem.fs"
#load "../../src/NavLink.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private navsSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            fragment [] [
                p [] [ str "List Based" ]
                Nav.nav [] [
                    NavItem.navItem [] [
                        NavLink.navLink [ NavLink.Custom [ Href "#" ] ] [
                            str "Link"
                        ]
                    ]
                    NavItem.navItem [] [
                        NavLink.navLink [ NavLink.Custom [ Href "#" ] ] [
                            str "Link"
                        ]
                    ]
                    NavItem.navItem [] [
                        NavLink.navLink [ NavLink.Custom [ Href "#" ] ] [
                            str "Another Link"
                        ]
                    ]
                    NavItem.navItem [] [
                        NavLink.navLink [ NavLink.Custom [ Href "#" ]
                                          NavLink.Custom [ Disabled true ] ] [
                            str "Disabled Link"
                        ]
                    ]
                ]
                hr []
                p [] [ str "Link Based" ]
                Nav.nav [] [
                    NavLink.navLink [ NavLink.Custom [ Href "#" ] ] [
                        str "Link"
                    ]
                    NavLink.navLink [ NavLink.Custom [ Href "#" ] ] [
                        str "Link"
                    ]
                    NavLink.navLink [ NavLink.Custom [ Href "#" ] ] [
                        str "Another Link"
                    ]
                    NavLink.navLink [ NavLink.Custom [ Href "#" ]
                                      NavLink.Custom [ Disabled true ] ] [
                        str "Disabled Link"
                    ]
                ]
            ]),
         "NavsSample")

exportDefault navsSample
