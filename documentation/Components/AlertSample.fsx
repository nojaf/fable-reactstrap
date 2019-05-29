#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Alert.fs"

open Fable.Core.JsInterop
open Fable.React
open ReactStrap

let private alertSample =
    FunctionComponent.Of<obj> (fun _ ->
        fragment [] [
            Alert.alert [ Alert.Color Primary ] [ str "This is a primary alert — check it out!" ]
            Alert.alert [ Alert.Color Info ] [ str "This is a secondary alert — check it out!" ]
            Alert.alert [ Alert.Color Success ] [ str "This is a success alert — check it out!" ]
            Alert.alert [ Alert.Color Danger ] [ str "This is a danger alert — check it out!" ]
            Alert.alert [ Alert.Color Warning ] [ str "This is a warning alert — check it out!" ]
            Alert.alert [ Alert.Color Info ] [ str "This is a info alert — check it out!" ]
            Alert.alert [ Alert.Color Light ] [ str "This is a light alert — check it out!" ]
            Alert.alert [ Alert.Color Dark ] [ str "This is a dark alert — check it out!" ]
        ]
    , "AlertSample")
    
exportDefault alertSample