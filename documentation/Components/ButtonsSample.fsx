#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Button.fs"

open ReactStrap
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

let private buttonsSample =
    FunctionComponent.Of
        (fun () ->
        fragment []
            [ div []
                  [ Button.button
                      [ Button.Color Primary
                        Button.Custom([ ClassName "mr-1" ]) ] [ str "primary" ]
                    Button.button
                        [ Button.Color Secondary
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "secondary" ]
                    Button.button
                        [ Button.Color Success
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "success" ]
                    Button.button
                        [ Button.Color Info
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "info" ]
                    Button.button
                        [ Button.Color Warning
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "warning" ]
                    Button.button
                        [ Button.Color Danger
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "danger" ]
                    Button.button
                        [ Button.Color Link
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "link" ] ]
              div [ ClassName "mt-2 mb-2" ]
                  [ h5 [] [ str "Outline" ]
                    Button.button
                        [ Button.Color Primary
                          Button.Outline true
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "primary" ]
                    Button.button
                        [ Button.Color Secondary
                          Button.Outline true
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "secondary" ]
                    Button.button
                        [ Button.Color Success
                          Button.Outline true
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "success" ]
                    Button.button
                        [ Button.Color Info
                          Button.Outline true
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "info" ]
                    Button.button
                        [ Button.Color Warning
                          Button.Outline true
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "warning" ]
                    Button.button
                        [ Button.Color Danger
                          Button.Outline true
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "danger" ] ]
              div [ ClassName "mt-2 mb-2" ]
                  [ h5 [] [ str "Sizes" ]
                    Button.button
                        [ Button.Color Primary
                          Button.Size Lg
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "Large button" ]
                    Button.button
                        [ Button.Color Secondary
                          Button.Size Lg
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "Large button" ]
                    Button.button
                        [ Button.Color Primary
                          Button.Size Sm
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "Small button" ]
                    Button.button
                        [ Button.Color Secondary
                          Button.Size Sm
                          Button.Custom([ ClassName "mr-1" ]) ] [ str "Small button" ]
                    Button.button
                        [ Button.Color Primary
                          Button.Block true
                          Button.Custom([ ClassName "mt-2" ]) ] [ str "Block level button" ] ]
              div [ ClassName "mt-2 mb-2" ]
                  [ h5 [] [ str "Active & disabled" ]
                    Button.button
                        [ Button.Color Primary
                          Button.Custom([ ClassName "mr-1" ])
                          Button.Active true ] [ str "primary" ]
                    Button.button
                        [ Button.Color Primary
                          Button.Custom
                              ([ ClassName "mr-1"
                                 Disabled true ]) ] [ str "primary" ] ]
              div [ ClassName "mt-2 mb-2" ]
                  [ h5 [] [ str "Close icon" ]
                    div []
                        [ span [] [ str "Default close icon" ]
                          Button.button [ Button.Close true ] [] ]
                    div [ ClassName "mt-2" ]
                        [ span [] [ str "Custom content" ]
                          Button.button [ Button.Close true ]
                              [ span [ DangerouslySetInnerHTML { __html = "&dash;" } ] [] ] ] ] ])

exportDefault buttonsSample
