#load "../.paket/load/netstandard2.0/main.group.fsx"

#if INTERACTIVE
#r "netstandard"
#endif

#load "../src/Common.fs"
#load "../src/Alert.fs"
#load "../src/Badge.fs"
#load "../src/Breadcrumb.fs"
#load "../src/BreadcrumbItem.fs"

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
            BreadcrumbItem.breadcrumbItem [BreadcrumbItem.Active] [str "Home"]
        ]
        Breadcrumb.breadcrumb [] [
            BreadcrumbItem.breadcrumbItem [] [
                a [Href "#"] [ str "Home"]
            ]
            BreadcrumbItem.breadcrumbItem [BreadcrumbItem.Active] [
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
            BreadcrumbItem.breadcrumbItem [BreadcrumbItem.Active] [
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
            BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Tag "span"; BreadcrumbItem.Active] [
                str "Bootstrap"
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
    ]

Helpers.mountById "app" combined