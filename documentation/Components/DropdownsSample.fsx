#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Dropdown.fs"
#load "../../src/DropdownToggle.fs"
#load "../../src/DropdownMenu.fs"
#load "../../src/DropdownItem.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private dropdownsSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            let isOpenState = Hooks.useState (false)
            let isOpenState1 = Hooks.useState (false)
            let isOpenState2 = Hooks.useState (false)
            let isOpenState3 = Hooks.useState (false)

            fragment []
                [
                  Dropdown.dropdown
                    [ Dropdown.IsOpen isOpenState.current
                      Dropdown.Toggle(fun () -> isOpenState.update(not isOpenState.current))
                    ]
                    [
                        DropdownToggle.dropdownToggle [ DropdownToggle.Caret true] [ str "Button Dropdown"]
                        DropdownMenu.dropdownMenu [] [
                            DropdownItem.dropdownItem [ DropdownItem.Header true ] [  str "Header" ]
                            DropdownItem.dropdownItem [] [  str "Some Action" ]
                            DropdownItem.dropdownItem [ DropdownItem.Disabled true] [  str "Action (disabled)" ]
                            DropdownItem.dropdownItem [ DropdownItem.Divider true ] [ ]
                            DropdownItem.dropdownItem [] [  str "Foo Action" ]
                            DropdownItem.dropdownItem [] [  str "Bar Action" ]
                            DropdownItem.dropdownItem [] [  str "Quo Action" ]
                        ]
                    ]
                  h5 [ ClassName "mt-2" ] [ str "Drop direction variations" ]
                  div [ ClassName "row"] [
                      div [ ClassName "col"] [
                          Dropdown.dropdown
                            [ Dropdown.IsOpen isOpenState1.current
                              Dropdown.Direction Up
                              Dropdown.Toggle(fun () -> isOpenState1.update(not isOpenState1.current))
                            ]
                            [
                                DropdownToggle.dropdownToggle [ DropdownToggle.Caret true] [ str "Dropup"]
                                DropdownMenu.dropdownMenu [] [
                                    DropdownItem.dropdownItem [] [  str "Another Action" ]
                                    DropdownItem.dropdownItem [] [  str "Another Action" ]
                                ]
                            ]
                        ]
                      div [ ClassName "col"] [
                          Dropdown.dropdown
                            [ Dropdown.IsOpen isOpenState2.current
                              Dropdown.Direction Direction.Left
                              Dropdown.Toggle(fun () -> isOpenState2.update(not isOpenState2.current))
                            ]
                            [
                                DropdownToggle.dropdownToggle [ DropdownToggle.Caret true] [ str "Dropleft"]
                                DropdownMenu.dropdownMenu [] [
                                    DropdownItem.dropdownItem [] [  str "Another Action" ]
                                    DropdownItem.dropdownItem [] [  str "Another Action" ]
                                ]
                            ]
                        ]
                      div [ ClassName "col"] [
                          Dropdown.dropdown
                            [ Dropdown.IsOpen isOpenState3.current
                              Dropdown.Direction Direction.Right
                              Dropdown.Toggle(fun () -> isOpenState3.update(not isOpenState3.current))
                            ]
                            [
                                DropdownToggle.dropdownToggle [ DropdownToggle.Caret true] [ str "Dropright"]
                                DropdownMenu.dropdownMenu [] [
                                    DropdownItem.dropdownItem [] [  str "Another Action" ]
                                    DropdownItem.dropdownItem [] [  str "Another Action" ]
                                ]
                            ]
                        ]
                    ]
                  ]
        )
    , "DropdownsSample")

exportDefault dropdownsSample
