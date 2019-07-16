#load "../.paket/load/netstandard2.0/main.group.fsx"
#load "../src/Common.fs"
#load "../src/Container.fs"
#load "../src/Row.fs"
#load "../src/Col.fs"
#load "../src/Jumbotron.fs"
#load "../src/Button.fs"
#load "HookRouter.fsx"
#load "./ReactPrism.fsx"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open ReactStrap
open ReactPrism

let private HomePage =
    FunctionComponent.Of<obj> (fun _ ->
        div [] [
            Jumbotron.jumbotron [Jumbotron.Custom [ClassName "text-center mb-3 bg-white"]] [
                Container.container [] [
                    Row.row [] [
                        Col.col [] [
                            p [ClassName "lead text-center"] [
                                img [Src "https://fable.io/img/fable_logo.png"; HTMLAttr.Width "150px" ]
                                img [Src "https://reactstrap.github.io/assets/logo.png"; HTMLAttr.Width "150px"]
                            ]
                            h1 [ClassName "jumbotron-heading display-4"] [ str "Fable Reactstrap" ]
                            p [ClassName "lead"] [str "Easy to use React Bootstrap 4 components with Fable"]
                            p [] [
                                Button.button [Button.Tag !^"a"; Button.Outline true; Button.Color Common.Primary
                                               Button.Custom [Href "https://github.com/nojaf/fable-reactstrap"; ClassName "mr-2"; Target "_blank"]] [ str "GitHub" ]
                                Button.button [Button.Tag !^ (HookRouter.AType) ; Button.Color Common.Primary
                                               Button.Custom [Href "/components"]] [ str "Components" ]
                            ]
                        ]
                    ]
                ]
            ]
            Container.container [] [
                h2 [ClassName "font-weight-light"] [str "Installation"]
                hr []
                h3 [ClassName "font-weight-light"] [str "NPM"]
                p [] [str "Install reactstrap and peer dependencies via NPM or Yarn"]
                prismCli "npm i --save reactstrap react react-dom"
                prismCli "yarn add reactstrap react react-dom"
                h3 [ClassName "font-weight-light mt-4"] [str ".NET"]
                p [] [str "Install Fable.Reactstrap via NuGet or Paket"]
                prismCli "dotnet add package Fable.Reactstrap"
                prismCli "paket add Fable.Reactstrap"
            ]
        ]
    , "Home")

exportDefault HomePage