open ReactStrap
open ReactStrap

#load "../.paket/load/netstandard2.0/main.group.fsx"

#if INTERACTIVE
#r "netstandard"
#endif

#load "../src/Common.fs"
#load "../src/Alert.fs"
#load "../src/Badge.fs"
#load "../src/Breadcrumb.fs"
#load "../src/BreadcrumbItem.fs"
#load "../src/Button.fs"
#load "../src/ButtonDropdown.fs"
#load "../src/DropdownToggle.fs"
#load "../src/DropdownMenu.fs"
#load "../src/DropdownItem.fs"
#load "../src/ButtonGroup.fs"
#load "../src/ButtonToolbar.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap
open Fable.React.Props

importSideEffects "./style.sass"

let private exampleBox children = div [ClassName "example-box"] children
let private exampleTitle title = h2 [] [str title]
    
let alertSample =
    exampleBox [
        Alert.alert [Alert.Color Primary] [ str "This is a primary alert — check it out!" ]
        Alert.alert [Alert.Color Info] [ str "This is a secondary alert — check it out!" ]
        Alert.alert [Alert.Color Success] [ str "This is a success alert — check it out!" ]
        Alert.alert [Alert.Color Danger] [ str "This is a danger alert — check it out!" ]
        Alert.alert [Alert.Color Warning] [ str "This is a warning alert — check it out!" ]
        Alert.alert [Alert.Color Info] [ str "This is a info alert — check it out!" ]
        Alert.alert [Alert.Color Light] [ str "This is a light alert — check it out!" ]
        Alert.alert [Alert.Color Dark] [ str "This is a dark alert — check it out!" ]
    ]
    
let badgeSample =
    exampleBox [
        h3 [] [
            str "Heading "
            Badge.badge [Badge.Color Secondary] [str "New"]    
        ]
        Badge.badge [Badge.Color Warning] [str "oh my"]
        Badge.badge [Badge.Color Dark; Badge.ClassName "ml-1"] [str "dark"]
        Badge.badge [Badge.ClassName "ml-1"] [str "badges"]
        div [] [
            Badge.badge [Badge.Color Info; Badge.Pill] [str "pill"]
        ]
        div [] [
            Badge.badge [Badge.Color Danger; Badge.Href "https://nojaf.com"] [str "with link"]
        ]
    ]

let breadcrumbsSample =
    exampleBox [
        Breadcrumb.breadcrumb [] [
            BreadcrumbItem.breadcrumbItem [BreadcrumbItem.Active true] [str "Home"]
        ]
        Breadcrumb.breadcrumb [] [
            BreadcrumbItem.breadcrumbItem [] [
                a [Href "#"] [ str "Home"]
            ]
            BreadcrumbItem.breadcrumbItem [BreadcrumbItem.Active true] [
                str "Library"
            ]
        ]
        Breadcrumb.breadcrumb [] [
            BreadcrumbItem.breadcrumbItem [] [
                a [Href "#"] [ str "Home"]
            ]
            BreadcrumbItem.breadcrumbItem [] [
                a [Href "#"] [ str "Library"]
            ]
            BreadcrumbItem.breadcrumbItem [BreadcrumbItem.Active true] [
                str "Data"
            ]
        ]
        p [] [str "No list" ]
        Breadcrumb.breadcrumb [Breadcrumb.Tag "nav"; Breadcrumb.ListTag "div"] [
            BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Tag "a"; BreadcrumbItem.Href "#"] [
                str "Home"
            ]
            BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Tag "a"; BreadcrumbItem.Href "#"] [
                str "Library"
            ]
            BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Tag "a"; BreadcrumbItem.Href "#"] [
                str "Data"
            ]
            BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Tag "span"; BreadcrumbItem.Active true] [
                str "Bootstrap"
            ]
        ]
    ]
    
let buttonSample =
    exampleBox [
        div [] [
            Button.button [Button.Color Primary; Button.ClassName "mr-1"] [str "primary"]
            Button.button [Button.Color Secondary; Button.ClassName "mr-1"] [str "secondary"]
            Button.button [Button.Color Success; Button.ClassName "mr-1"] [str "success"]
            Button.button [Button.Color Info; Button.ClassName "mr-1"] [str "info"]
            Button.button [Button.Color Warning; Button.ClassName "mr-1"] [str "warning"]
            Button.button [Button.Color Danger; Button.ClassName "mr-1"] [str "danger"]
            Button.button [Button.Color Link; Button.ClassName "mr-1"] [str "link"]
        ]
        div [ClassName "mt-2 mb-2"] [
            h5 [] [str "Outline"]
            Button.button [Button.Color Primary; Button.Outline true; Button.ClassName "mr-1"] [str "primary"]
            Button.button [Button.Color Secondary; Button.Outline true; Button.ClassName "mr-1"] [str "secondary"]
            Button.button [Button.Color Success; Button.Outline true; Button.ClassName "mr-1"] [str "success"]
            Button.button [Button.Color Info; Button.Outline true; Button.ClassName "mr-1"] [str "info"]
            Button.button [Button.Color Warning; Button.Outline true; Button.ClassName "mr-1"] [str "warning"]
            Button.button [Button.Color Danger; Button.Outline true; Button.ClassName "mr-1"] [str "danger"]
        ]
        div [ClassName "mt-2 mb-2"] [
            h5 [ ] [str "Sizes"]
            Button.button [Button.Color Primary; Button.Size Lg; Button.ClassName "mr-1"] [str "Large button"]
            Button.button [Button.Color Secondary; Button.Size Lg; Button.ClassName "mr-1"] [str "Large button"]
            Button.button [Button.Color Primary; Button.Size Sm; Button.ClassName "mr-1"] [str "Small button"]
            Button.button [Button.Color Secondary; Button.Size Sm; Button.ClassName "mr-1"] [str "Small button"]
            Button.button [Button.Color Primary; Button.Block true; Button.ClassName "mt-2"] [str "Block level button"]
        ]
        div [ClassName "mt-2 mb-2"] [
            h5 [] [str "Active & disabled"]
            Button.button [Button.Color Primary; Button.ClassName "mr-1"; Button.Active true] [str "primary"]
            Button.button [Button.Color Primary; Button.ClassName "mr-1"; Button.Disabled true] [str "primary"]
        ]
        div [ClassName "mt-2 mb-2"] [
            h5 [] [str "Close icon"]
            div [] [
                span [] [str "Default close icon"]
                Button.button [Button.Close true] []
            ]
            div [ ClassName "mt-2" ] [
                span [] [str "Custom content"]
                Button.button [Button.Close true] [ span [DangerouslySetInnerHTML { __html = "&dash;" }] [] ]
            ]
        ]
    ]
    
let buttonDropdown _ =
    let isOpenState = Hooks.useState(false)
    
    exampleBox [
        ButtonDropdown.buttonDropdown [ButtonDropdown.IsOpen isOpenState.current; ButtonDropdown.Toggle (fun () -> isOpenState.update(not isOpenState.current))] [
            DropdownToggle.dropdownToggle [DropdownToggle.Caret true] [str "Button Dropdown"]
            DropdownMenu.dropdownMenu [] [
                DropdownItem.dropdownItem [DropdownItem.Header true] [str "Header"]
                DropdownItem.dropdownItem [DropdownItem.Disabled true] [str "Action"]
                DropdownItem.dropdownItem [] [str "Another Action"]
                DropdownItem.dropdownItem [DropdownItem.Divider true] []
                DropdownItem.dropdownItem [] [str "Another Action"]
            ]
        ]
    ]
    
let buttonGroupSample _ =
    let isOpenState = Hooks.useState(false)
    let isOpenState2 = Hooks.useState(false)
    
    exampleBox [
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
        ButtonGroup.buttonGroup [ButtonGroup.ClassName "mt-2"] [
            Button.button [] [str "Left"]
            Button.button [] [str "Middle"]
            Button.button [] [str "Right"]
        ]
        br []
        ButtonGroup.buttonGroup [ButtonGroup.Size Sm; ButtonGroup.ClassName "mt-2"] [
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

let combined =
    fragment [] [
        exampleTitle "Alert"
        alertSample
        exampleTitle "Badges"
        badgeSample
        exampleTitle "Breadcrumbs"
        breadcrumbsSample
        exampleTitle "Buttons"
        buttonSample
        exampleTitle "Button Dropdown"
        ofFunction buttonDropdown () []
        exampleTitle "Button Group"
        ofFunction buttonGroupSample () []
    ]

Helpers.mountById "app" combined