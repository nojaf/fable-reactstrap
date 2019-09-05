#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Progress.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private progressSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
        fragment []
            [
                div [ ]
                    [ div [ ClassName "text-center" ]
                        [ str "0%" ]
                      Progress.progress [ ]
                        [ ]
                      div [ ClassName "text-center" ]
                        [ str "25%" ]
                      Progress.progress [ Progress.Value !^ "25" ]
                        [ ]
                      div [ ClassName "text-center" ]
                        [ str "50%" ]
                      Progress.progress [ Progress.Value !^ "50" ]
                        [ ]
                      div [ ClassName "text-center" ]
                        [ str "75%" ]
                      Progress.progress [ Progress.Value !^ "75" ]
                        [ ]
                      div [ ClassName "text-center" ]
                        [ str "100%" ]
                      Progress.progress [ Progress.Value !^ "100" ]
                        [ ]
                      div [ ClassName "text-center" ]
                        [ str "Multiple bars" ]
                      Progress.progress [ Progress.Multi true]
                        [ Progress.progress [
                                     Progress.Bar true
                                     Progress.Value !^ "15" ]
                            [ ]
                          Progress.progress [
                                     Progress.Bar true
                                     Progress.Color Success
                                     Progress.Value !^ "30" ]
                            [ ]
                          Progress.progress [
                                     Progress.Bar true
                                     Progress.Color Info
                                     Progress.Value !^ "25" ]
                            [ ]
                          Progress.progress [
                                      Progress.Bar true
                                      Progress.Color Warning
                                      Progress.Value !^  "20" ]
                            [ ]
                          Progress.progress [
                                     Progress.Bar true
                                     Progress.Color Danger
                                     Progress.Value !^  "5" ]
                            [ ] ] ]
            ]
        ), "ProgressSample")

exportDefault progressSample
