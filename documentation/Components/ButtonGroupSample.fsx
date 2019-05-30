#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/ButtonGroup.fs"
#load "../../src/Button.fs"
#load "../../src/ButtonToolbar.fs"
#load "../../src/ButtonDropdown.fs"
#load "../../src/DropdownToggle.fs"
#load "../../src/DropdownMenu.fs"
#load "../../src/DropdownItem.fs"

open ReactStrap
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

let private buttonGroupSample =
    FunctionComponent.Of(fun () ->
        let isOpenState = Hooks.useState(false)
        let isOpenState2 = Hooks.useState(false)
    
        fragment [] [
            ButtonGroup.buttonGroup [] [
                Button.button [] [str "Left"]
                Button.button [] [str "Middle"]
                Button.button [] [str "Right"]
            ]
            h5 [ClassName "mt-2"] [str "Button toolbar"]
            ButtonToolbar.buttonToolbar [] [
                ButtonGroup.buttonGroup [] [
                    Button.button [] [ofInt 1]
                    Button.button [] [ofInt 2]
                    Button.button [] [ofInt 3]
                    Button.button [] [ofInt 4]
                ]
                ButtonGroup.buttonGroup [] [
                    Button.button [] [ofInt 5]
                    Button.button [] [ofInt 6]
                    Button.button [] [ofInt 7]
                ]
                ButtonGroup.buttonGroup [] [
                    Button.button [] [ofInt 8]
                ]
            ]
            h5 [ClassName "mt-2"] [str "Sizing"]
            ButtonGroup.buttonGroup [ButtonGroup.Size Lg] [
                Button.button [] [str "Left"]
                Button.button [] [str "Middle"]
                Button.button [] [str "Right"]
            ]
            br []
            ButtonGroup.buttonGroup [ButtonGroup.Custom ([ClassName "mt-2"]) ] [
                Button.button [] [str "Left"]
                Button.button [] [str "Middle"]
                Button.button [] [str "Right"]
            ]
            br []
            ButtonGroup.buttonGroup [ButtonGroup.Size Sm; ButtonGroup.Custom([ClassName "mt-2"]) ] [
                Button.button [] [str "Left"]
                Button.button [] [str "Middle"]
                Button.button [] [str "Right"]
            ]
            h5 [ClassName "mt-2"] [str "Nesting"]
            ButtonGroup.buttonGroup [] [
                Button.button [] [ofInt 1]
                Button.button [] [ofInt 2]
                ButtonDropdown.buttonDropdown [ButtonDropdown.IsOpen isOpenState.current; ButtonDropdown.Toggle (fun () -> isOpenState.update(not isOpenState.current))] [
                    DropdownToggle.dropdownToggle [DropdownToggle.Caret true] [
                        str "Dropdown"
                    ]
                    DropdownMenu.dropdownMenu [] [
                        DropdownItem.dropdownItem [] [str "Dropdown link"]
                        DropdownItem.dropdownItem [] [str "Dropdown link"]
                    ]
                ]
            ]
            h5 [ClassName "mt-2"] [str "Vertical variation"]
            ButtonGroup.buttonGroup [ButtonGroup.Vertical true] [
                Button.button [] [ofInt 1]
                Button.button [] [ofInt 2]
                ButtonDropdown.buttonDropdown [ButtonDropdown.IsOpen isOpenState2.current; ButtonDropdown.Toggle (fun () -> isOpenState2.update(not isOpenState2.current))] [
                    DropdownToggle.dropdownToggle [DropdownToggle.Caret true] [
                        str "Dropdown"
                    ]
                    DropdownMenu.dropdownMenu [] [
                        DropdownItem.dropdownItem [] [str "Dropdown link"]
                        DropdownItem.dropdownItem [] [str "Dropdown link"]
                    ]
                ]
            ]
        ]
    )
    
exportDefault buttonGroupSample