#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/ButtonDropdown.fs"
#load "../../src/DropdownToggle.fs"
#load "../../src/DropdownMenu.fs"
#load "../../src/DropdownItem.fs"
#load "../../src/Button.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open ReactStrap

let private buttonDropdownSample =
    FunctionComponent.Of (fun () ->
        let isOpenState = Hooks.useState(false)
        let isOpenState2 = Hooks.useState(false)
        let isOpenState3 = Hooks.useState(false)
        
        fragment [] [
            ButtonDropdown.buttonDropdown
                [ ButtonDropdown.IsOpen isOpenState.current
            
                  ButtonDropdown.Toggle
                      (fun () -> isOpenState.update (not isOpenState.current)) ]
                [ DropdownToggle.dropdownToggle [ DropdownToggle.Caret true ]
                      [ str "Button Dropdown" ]
                  DropdownMenu.dropdownMenu []
                      [ DropdownItem.dropdownItem [ DropdownItem.Header true ]
                            [ str "Header" ]
            
                        DropdownItem.dropdownItem [ DropdownItem.Disabled true ]
                            [ str "Action" ]
                        DropdownItem.dropdownItem [] [ str "Another Action" ]
                        DropdownItem.dropdownItem [ DropdownItem.Divider true ] []
                        DropdownItem.dropdownItem [] [ str "Another Action" ] ] ]
            h5 [ ClassName "mt-2" ] [ str "Split button dropdowns" ]
            ButtonDropdown.buttonDropdown
                [ ButtonDropdown.IsOpen isOpenState2.current
            
                  ButtonDropdown.Toggle
                      (fun () -> isOpenState2.update (not isOpenState2.current)) ]
                [ Button.button [ Button.Color Primary ] [ str "primary" ]
                  DropdownToggle.dropdownToggle
                      [ DropdownToggle.Caret true
                        DropdownToggle.Color Primary ] []
                  DropdownMenu.dropdownMenu []
                      [ DropdownItem.dropdownItem [ DropdownItem.Header true ]
                            [ str "Header" ]
            
                        DropdownItem.dropdownItem [ DropdownItem.Disabled true ]
                            [ str "Action" ]
                        DropdownItem.dropdownItem [] [ str "Another Action" ] ] ]
            h5 [ ClassName "mt-2" ] [ str "Sizing" ]
            ButtonDropdown.buttonDropdown
                [ ButtonDropdown.IsOpen isOpenState3.current
            
                  ButtonDropdown.Toggle
                      (fun () -> isOpenState3.update (not isOpenState3.current)) ]
                [ DropdownToggle.dropdownToggle
                    [ DropdownToggle.Caret true
                      DropdownToggle.Size Lg ] [ str "Large Button" ]
                  DropdownMenu.dropdownMenu []
                      [ DropdownItem.dropdownItem [] [ str "Another action" ]
                        DropdownItem.dropdownItem [] [ str "Another action" ] ] ]
        ]
    )

exportDefault buttonDropdownSample