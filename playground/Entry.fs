module Entry

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open HookRouter
open System
open Browser
open Playground.Components

importSideEffects "./style.sass"
importSideEffects "prismjs"
importSideEffects "prismjs/components/prism-fsharp"
importSideEffects "./prism-monokai.css"


let routes =
    createObj [
        "/components/alerts" ==> fun _ -> AlertSample.alertSample
        "/components/badge" ==> fun _ -> BadgeSample.badgeSample
        "/components/breadcrumbs" ==> fun _ -> BreadcrumbsSample.breadcrumbsSample
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

let App =
    FunctionComponent.Of (fun _ ->
        useRedirect "/" "/components/alerts" None (Some false)
        useRedirect "/components" "/components/alerts" None (Some false)
        let routeResults = useRoutes routes
        let path = usePath()
        
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

        match routeResults with
        | Some r ->
            div [ ClassName "container content" ] [
                div [ClassName "row"] [
                    main [ClassName "col-md-3 order-md-2"] [
                        div [ClassName "mb-3 docs-sidebar"] [
                            h1 [ClassName "h5"] [str "Components"]
                            ul [ClassName "flex-column nav"] menuItems
                        ]
                    ]
                    aside [ClassName "col-md-9 order-md-1"] [
                        h2 [ClassName "h3"] [str activePageName]
                        div [ClassName "docs-example"] [r]
                    ]
                ]
            ]
        | None -> NotFoundPage

    , "App")


let app = document.getElementById "app"
ReactDom.render(App(), app)