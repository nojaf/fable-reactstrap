module Entry

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open HookRouter
open System
open ReactStrap
open Browser
open Fable.Core

importSideEffects "./style.sass"
importSideEffects "prismjs"
importSideEffects "prismjs/components/prism-fsharp"
importSideEffects "./prism-monokai.css"

let rl = ReactBindings.React.``lazy``

let AlertSample : obj = rl(fun() -> importDynamic "./Components/AlertSample.fsx")
let BadgeSample : obj = rl(fun() -> importDynamic "./Components/BadgeSample.fsx")
let BreadcrumbsSample : obj = rl(fun() -> importDynamic "./Components/BreadcrumbsSample.fsx")
let ButtonDropdownSample : obj = rl(fun() -> importDynamic "./Components/ButtonDropdownSample.fsx")

type SuspenseProp =
    | Fallback of ReactElement
    
let suspense props children =
    ofImport "Suspense" "react" (keyValueList CaseRules.LowerFirst props) children
    
let rce = ReactBindings.React.createElement

let routes =
    createObj [
        "/components/alerts" ==> fun _ -> rce(AlertSample, null, [])
        "/components/badge" ==> fun _ -> rce(BadgeSample, null, [])
        "/components/breadcrumbs" ==> fun _ -> rce(BreadcrumbsSample, null, [])
        "/components/button-dropdown" ==> fun _ -> rce(ButtonDropdownSample, null, [])
        //"/components/breadcrumbs" ==> fun _ -> BreadcrumbsSample.breadcrumbsSample
        //"/components/button-dropdown" ==> fun _ -> ButtonDropdownSample.buttonDropdownSample ()
    ]

let routeUrls = Fable.Core.JS.Object.keys(routes)

let NotFoundPage =
    div [ ]
        [ section [ ClassName "jumbotron text-center mb-3" ]
            [ div [ ClassName "container" ]
                [ div [ ClassName "row" ]
                    [ div [ ClassName "col" ]
                        [ p [ ClassName "lead" ]
                            [ img [ Src "/assets/logo.png"
                                    Alt ""
                                    HTMLAttr.Width "150px" ] ]
                          h1 [ ClassName "jumbotron-heading display-4" ]
                            [ str "404 - Not Found" ]
                          p [ ClassName "lead" ]
                            [ str "Can't find what you're looking for?"
                              br []
                              a [ Href "https://github.com/nojaf/fablereactstrap/issues/new" ] [ str "Open up an issue." ]
                            ]
                           ] ] ] ] ]
        
let urlToName (url:string) =
    url.Replace("/components/", "").Split('-')
    |> Array.map (fun word -> String.Concat(System.Char.ToUpper(word.[0]), word.Substring(1)))
    |> String.concat " "
    
let layout path body =
    let menuItems =
        routeUrls
        |> Seq.map (fun url ->
            let className = if url = path then "nav-link active" else "nav-link"
            let text = urlToName url

            li [ClassName "nav-item"] [
                A [ AProps.ClassName className; AProps.Href url] [str text]
            ]
        )

    let activePageName = urlToName path
    
    fragment [] [
        Nav.nav [Nav.Navbar true; Nav.ClassName "navbar navbar-expand-md navbar-light header"] [
            Container.container [] [
                A [AProps.Href "/"; AProps.ClassName "mr-auto navbrand-bar"] [str "Fable Reactstrap"]
                div [ClassName "collapse navbar-collapse"] [
                    Navbar.navbar [Navbar.ClassName "ml-sm-auto"] [
                        NavItem.navItem [] [ a [Href "https://github.com/nojaf/fable-reactstrap"; Target "_blank"] [str "Github"] ]
                    ]
                ]
            ]
        ]
        Container.container [] [
            Row.row [] [
                Col.col [Col.Md (Col.mkCol !^3 |> Col.withOrder !^2); Col.Tag "main" ] [
                    div [ClassName "mb-3 docs-sidebar"] [
                        h1 [ClassName "h5"] [str "Components"]
                        ul [ClassName "flex-column nav"] menuItems
                    ]
                ]
                Col.col [Col.Md (Col.mkCol !^9 |> Col.withOrder !^ 1); Col.Tag "aside"] [
                    h2 [ClassName "h3"] [str activePageName]
                    div [ClassName "docs-example"] [body; importDefault "!!raw-loader!./Script.fsx" |> str]
                ]
            ]
        ]
    ]
    
let Loading =
    div [ Id "preloader"] [
        div [Id "loader"] []
    ]

let App =
    FunctionComponent.Of (fun _ ->
        useRedirect "/" "/components/alerts" None (Some false)
        useRedirect "/components" "/components/alerts" None (Some false)
        let routeResults = useRoutes routes
        let path = usePath()

        match routeResults with
        | Some r -> suspense [Fallback Loading] [ layout path r ]
        | None -> NotFoundPage

    , "App")


let app = document.getElementById "app"
ReactDom.render(App(), app)