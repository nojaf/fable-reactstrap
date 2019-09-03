#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Nav.fs"
#load "../../src/NavItem.fs"
#load "../../src/NavLink.fs"
#load "../../src/TabContent.fs"
#load "../../src/TabPane.fs"
#load "../../src/Row.fs"
#load "../../src/Col.fs"
#load "../../src/Card.fs"
#load "../../src/CardTitle.fs"
#load "../../src/CardText.fs"
#load "../../src/Button.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private tabsSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            let tabIndex = Hooks.useState(1)
            fragment [] [
                div [ ]
                    [ Nav.nav [
                        Nav.Tabs true
                        ]
                        [ NavItem.navItem [ ]
                            [ NavLink.navLink [
                                        tabIndex.current=1 |> NavLink.Active
                                        NavLink.Custom [ OnClick (fun _ -> tabIndex.update 1) ]
                                    ]
                                [ str "Tab1" ] ]
                          NavItem.navItem [ ]
                            [ NavLink.navLink [
                                        tabIndex.current=2 |> NavLink.Active
                                        NavLink.Custom [ OnClick (fun _ -> tabIndex.update 2) ]
                                        ]
                                [ str "Moar Tabs" ] ] ]
                      TabContent.tabContent [
                          TabContent.ActiveTab !^ tabIndex.current
                          ]
                        [ TabPane.tabPane [
                            TabPane.TabId !^1
                            ]
                            [ Row.row [ ]
                                [ Col.col [
                                    Col.Sm (Col.mkCol !^12)
                                    ] [
                                  h4 [ ]
                                    [ str "Tab 1 Contents" ] ] ] ]
                          TabPane.tabPane [
                              TabPane.TabId !^2
                              ]
                            [ Row.row [ ]
                                [ Col.col [
                                    Col.Sm (Col.mkCol !^6)
                                    ] [
                                  Card.card [
                                      Card.Body true
                                      ]
                                    [ CardTitle.cardTitle [ ]
                                        [ str "Special Title Treatment" ]
                                      CardText.cardText [ ]
                                        [ str "With supporting text below as a natural lead-in to additional content." ]
                                      Button.button [ ]
                                        [ str "Go somewhere" ] ] ]
                                  Col.col [
                                      Col.Sm (Col.mkCol !^6)
                                      ] [
                                  Card.card [
                                      Card.Body true
                                      ]
                                    [ CardTitle.cardTitle [ ]
                                        [ str "Special Title Treatment" ]
                                      CardText.cardText [ ]
                                        [ str "With supporting text below as a natural lead-in to additional content." ]
                                      Button.button [ ]
                                        [ str "Go somewhere" ] ] ] ] ] ] ]
        ]), "TabsSample")

exportDefault tabsSample
