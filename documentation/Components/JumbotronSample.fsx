#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Jumbotron.fs"
#load "../../src/Button.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private jumbotronSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            Jumbotron.jumbotron [] [
                h1 [ ClassName "display-3 "] [ str "Hello, world!"]
                p  [ ClassName "lead"] [ str "This is a simple hero unit, a simple Jumbotron-style component for calling extra attention to featured content or information."]
                hr [ ClassName "my-2"]
                p  [] [ str "It uses utility classes for typography and spacing to space content out within the larger container."]
                p  [ ClassName "lead"] [
                        Button.button [ Button.Color Primary] [ str "Learn More"]
                    ]
            ]
        )
        , "JumbotronSample")

exportDefault jumbotronSample
