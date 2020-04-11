#load "../.paket/load/netstandard2.0/main.group.fsx"
#load "./HookRouter.fsx"
#load "./ReactPrism.fsx"
#load "../src/Common.fs"
#load "../src/Container.fs"
#load "../src/Row.fs"
#load "../src/Col.fs"
#load "../src/Nav.fs"
#load "../src/Navbar.fs"
#load "../src/NavItem.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open HookRouter
open System
open Reactstrap
open Browser
open Fable.Core
open ReactPrism

importSideEffects "./style.sass"
importSideEffects "prismjs"
importSideEffects "prismjs/components/prism-fsharp"
importSideEffects "./prism-monokai.css"

let rl = ReactBindings.React.``lazy``

let HomePage: obj = rl (fun () -> importDynamic "./Home.fsx")
let AlertSample: obj = rl (fun () -> importDynamic "./Components/AlertSample.fsx")
let BadgeSample: obj = rl (fun () -> importDynamic "./Components/BadgeSample.fsx")
let BreadcrumbsSample: obj = rl (fun () -> importDynamic "./Components/BreadcrumbsSample.fsx")
let ButtonDropdownSample: obj = rl (fun () -> importDynamic "./Components/ButtonDropdownSample.fsx")
let ButtonGroupSample: obj = rl (fun () -> importDynamic "./Components/ButtonGroupSample.fsx")
let ButtonsSample: obj = rl (fun () -> importDynamic "./Components/ButtonsSample.fsx")
let CardSample: obj = rl (fun () -> importDynamic "./Components/CardSample.fsx")
let CarouselSample: obj = rl (fun () -> importDynamic "./Components/CarouselSample.fsx")
let CollapseSample: obj = rl (fun () -> importDynamic "./Components/CollapseSample.fsx")
let DropdownsSample: obj = rl (fun () -> importDynamic "./Components/DropdownsSample.fsx")
let FadeSample: obj = rl (fun () -> importDynamic "./Components/FadeSample.fsx")
let FormSample: obj = rl (fun () -> importDynamic "./Components/FormSample.fsx")
let InputGroupSample: obj = rl (fun () -> importDynamic "./Components/InputGroupSample.fsx")
let JumbotronSample: obj = rl (fun () -> importDynamic "./Components/JumbotronSample.fsx")
let LayoutSample: obj = rl (fun () -> importDynamic "./Components/LayoutSample.fsx")
let ListGroupSample: obj = rl (fun () -> importDynamic "./Components/ListGroupSample.fsx")
let MediaSample: obj = rl (fun () -> importDynamic "./Components/MediaSample.fsx")
let ModalsSample: obj = rl (fun () -> importDynamic "./Components/ModalsSample.fsx")
let NavbarSample: obj = rl (fun () -> importDynamic "./Components/NavbarSample.fsx")
let NavsSample: obj = rl (fun () -> importDynamic "./Components/NavsSample.fsx")
let PaginationSample: obj = rl (fun () -> importDynamic "./Components/PaginationSample.fsx")
let PopoversSample: obj = rl (fun () -> importDynamic "./Components/PopoversSample.fsx")
let ProgressSample: obj = rl (fun () -> importDynamic "./Components/ProgressSample.fsx")
let SpinnersSample: obj = rl (fun () -> importDynamic "./Components/SpinnersSample.fsx")
let TablesSample: obj = rl (fun () -> importDynamic "./Components/TablesSample.fsx")
let TabsSample: obj = rl (fun () -> importDynamic "./Components/TabsSample.fsx")
let ToastsSample: obj = rl (fun () -> importDynamic "./Components/ToastsSample.fsx")
let TooltipsSample: obj = rl (fun () -> importDynamic "./Components/TooltipsSample.fsx")

let showComponent comp sourceCode =
    fragment []
        [ ReactBindings.React.createElement (comp, null, [])
          prismCode sourceCode ]

let homeRoute = "/"

let routes =
    createObj
        [ "/" ==> fun _ -> ReactBindings.React.createElement (HomePage, null, [])
          "/components/alerts"
          ==> fun _ -> showComponent AlertSample (importDefault "!!raw-loader!./Components/AlertSample.fsx")
          "/components/badge"
          ==> fun _ -> showComponent BadgeSample (importDefault "!!raw-loader!./Components/BadgeSample.fsx")
          "/components/breadcrumbs"
          ==> fun _ ->
              showComponent BreadcrumbsSample (importDefault "!!raw-loader!./Components/BreadcrumbsSample.fsx")
          "/components/button-dropdown"
          ==> fun _ ->
              showComponent ButtonDropdownSample (importDefault "!!raw-loader!./Components/ButtonDropdownSample.fsx")
          "/components/button-group"
          ==> fun _ ->
              showComponent ButtonGroupSample (importDefault "!!raw-loader!./Components/ButtonGroupSample.fsx")
          "/components/buttons"
          ==> fun _ -> showComponent ButtonsSample (importDefault "!!raw-loader!./Components/ButtonsSample.fsx")
          "/components/card"
          ==> fun _ -> showComponent CardSample (importDefault "!!raw-loader!./Components/CardSample.fsx")
          "/components/carousel"
          ==> fun _ -> showComponent CarouselSample (importDefault "!!raw-loader!./Components/CarouselSample.fsx")
          "/components/collapse"
          ==> fun _ -> showComponent CollapseSample (importDefault "!!raw-loader!./Components/CollapseSample.fsx")
          "/components/dropdowns"
          ==> fun _ -> showComponent DropdownsSample (importDefault "!!raw-loader!./Components/DropdownsSample.fsx")
          "/components/fade"
          ==> fun _ -> showComponent FadeSample (importDefault "!!raw-loader!./Components/FadeSample.fsx")
          "/components/form"
          ==> fun _ -> showComponent FormSample (importDefault "!!raw-loader!./Components/FormSample.fsx")
          "/components/input-group"
          ==> fun _ -> showComponent InputGroupSample (importDefault "!!raw-loader!./Components/InputGroupSample.fsx")
          "/components/jumbotron"
          ==> fun _ -> showComponent JumbotronSample (importDefault "!!raw-loader!./Components/JumbotronSample.fsx")
          "/components/layout"
          ==> fun _ -> showComponent LayoutSample (importDefault "!!raw-loader!./Components/LayoutSample.fsx")
          "/components/list-group"
          ==> fun _ -> showComponent ListGroupSample (importDefault "!!raw-loader!./Components/ListGroupSample.fsx")
          "/components/media"
          ==> fun _ -> showComponent MediaSample (importDefault "!!raw-loader!./Components/MediaSample.fsx")
          "/components/modals"
          ==> fun _ -> showComponent ModalsSample (importDefault "!!raw-loader!./Components/ModalsSample.fsx")
          "/components/navbar"
          ==> fun _ -> showComponent NavbarSample (importDefault "!!raw-loader!./Components/NavbarSample.fsx")
          "/components/navs"
          ==> fun _ -> showComponent NavsSample (importDefault "!!raw-loader!./Components/NavsSample.fsx")
          "/components/pagination"
          ==> fun _ -> showComponent PaginationSample (importDefault "!!raw-loader!./Components/PaginationSample.fsx")
          "/components/popovers"
          ==> fun _ -> showComponent PopoversSample (importDefault "!!raw-loader!./Components/PopoversSample.fsx")
          "/components/progress"
          ==> fun _ -> showComponent ProgressSample (importDefault "!!raw-loader!./Components/ProgressSample.fsx")
          "/components/spinners"
          ==> fun _ -> showComponent SpinnersSample (importDefault "!!raw-loader!./Components/SpinnersSample.fsx")
          "/components/tables"
          ==> fun _ -> showComponent TablesSample (importDefault "!!raw-loader!./Components/TablesSample.fsx")
          "/components/tabs"
          ==> fun _ -> showComponent TabsSample (importDefault "!!raw-loader!./Components/TabsSample.fsx")
          "/components/toasts"
          ==> fun _ -> showComponent ToastsSample (importDefault "!!raw-loader!./Components/ToastsSample.fsx")
          "/components/tooltips"
          ==> fun _ -> showComponent TooltipsSample (importDefault "!!raw-loader!./Components/TooltipsSample.fsx") ]

let routeUrls = Fable.Core.JS.Constructors.Object.keys (routes)

let NotFoundPage =
    div []
        [ section [ ClassName "jumbotron text-center mb-3" ]
              [ div [ ClassName "container" ]
                    [ div [ ClassName "row" ]
                          [ div [ ClassName "col" ]
                                [ h1 [ ClassName "jumbotron-heading display-4" ] [ str "404 - Not Found" ]
                                  p [ ClassName "lead" ]
                                      [ str "Can't find what you're looking for?"
                                        br []
                                        a [ Href "https://github.com/nojaf/fablereactstrap/issues/new" ]
                                            [ str "Open up an issue." ] ] ] ] ] ] ]

let urlToName (url: string) =
    url.Replace("/fable-reactstrap/components/", "").Replace("/components/", "").Split('-')
    |> Array.map (fun word -> String.Concat(System.Char.ToUpper(word.[0]), word.Substring(1)))
    |> String.concat " "

let layout path body =
    let menuItems =
        routeUrls
        |> Seq.filter (fun p -> p <> homeRoute)
        |> Seq.map (fun url ->
            let className =
                if url = path then "nav-link active"
                else "nav-link"

            let text = urlToName url

            li [ ClassName "nav-item" ]
                [ A
                    [ AProps.ClassName className
                      AProps.Href url ] [ str text ] ])


    let activePageName, example =
        if path <> homeRoute then urlToName path, div [ ClassName "docs-example" ] [ body ]
        else "Fable Reactstrap", body


    fragment []
        [ Nav.nav
            [ Nav.Navbar true
              Nav.Custom([ ClassName "navbar navbar-expand-md navbar-light header" ]) ]
              [ Container.container []
                    [ A
                        [ AProps.Href homeRoute
                          AProps.ClassName "mr-auto navbrand-bar" ] [ str "Fable Reactstrap" ]
                      div [ ClassName "collapse navbar-collapse" ]
                          [ Navbar.navbar [ Navbar.Custom([ ClassName "ml-sm-auto" ]) ]
                                [ NavItem.navItem []
                                      [ a
                                          [ Href "https://github.com/nojaf/fable-reactstrap"
                                            Target "_blank" ] [ str "GitHub" ] ] ] ] ] ]
          Container.container []
              [ Row.row []
                    [ Col.col
                        [ Col.Md(Col.mkCol !^3 |> Col.withOrder !^2)
                          Col.Tag !^"main" ]
                          [ div [ ClassName "mb-3 docs-sidebar" ]
                                [ h1 [ ClassName "h5" ] [ str "Components" ]
                                  ul [ ClassName "flex-column nav" ] menuItems ] ]
                      Col.col
                          [ Col.Md(Col.mkCol !^9 |> Col.withOrder !^1)
                            Col.Tag !^"aside" ]
                          [ h2 [ ClassName "h3" ] [ str activePageName ]
                            example ] ] ] ]

let Loading = div [ Id "preloader" ] [ div [ Id "loader" ] [] ]

type SuspenseProp = Fallback of ReactElement

let suspense props children = ofImport "Suspense" "react" (keyValueList CaseRules.LowerFirst props) children

#if !DEBUG
setBasepath "/fable-reactstrap"
#endif

let App =
    FunctionComponent.Of
        ((fun _ ->
            useRedirect "/components" "/components/alerts" None (Some false)
            let routeResults = useRoutes routes
            let path = usePath()

            match routeResults with
            | Some r -> suspense [ Fallback Loading ] [ layout path r ]
            | None -> NotFoundPage),
         "App")

let app = document.getElementById "app"

ReactDom.render (App(), app)
