#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Fade.fs"
#load "../../src/Button.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private fadeSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            let fadeIn = Hooks.useState(true)
            fragment []
                [
                    Button.button [
                        Button.Color Primary
                        Button.Custom [ClassName "mb-4"; OnClick(fun _ -> fadeIn.update(not fadeIn.current) )]
                    ] [str "Toggle Fade"]
                    Fade.fade [
                        Fade.In fadeIn.current
                    ] [
                        str "This content will fade in and out as the button is pressed"
                      ]
                ]
          )
        , "FadeSample")

exportDefault fadeSample
