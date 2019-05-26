module Playground.Components.AlertSample

open Fable.React
open ReactStrap
open ReactPrism

let alertSample =
    fragment [] [
        Alert.alert [ Alert.Color Primary ] [ str "This is a primary alert — check it out!" ]
        Alert.alert [ Alert.Color Info ] [ str "This is a secondary alert — check it out!" ]
        Alert.alert [ Alert.Color Success ] [ str "This is a success alert — check it out!" ]
        Alert.alert [ Alert.Color Danger ] [ str "This is a danger alert — check it out!" ]
        Alert.alert [ Alert.Color Warning ] [ str "This is a warning alert — check it out!" ]
        Alert.alert [ Alert.Color Info ] [ str "This is a info alert — check it out!" ]
        Alert.alert [ Alert.Color Light ] [ str "This is a light alert — check it out!" ]
        Alert.alert [ Alert.Color Dark ] [ str "This is a dark alert — check it out!" ]
        prismCode """open Fable.React
open ReactStrap

Alert.alert [ Alert.Color Primary ] [ str "This is a primary alert — check it out!" ]
Alert.alert [ Alert.Color Info ] [ str "This is a secondary alert — check it out!" ]
Alert.alert [ Alert.Color Success ] [ str "This is a success alert — check it out!" ]
Alert.alert [ Alert.Color Danger ] [ str "This is a danger alert — check it out!" ]
Alert.alert [ Alert.Color Warning ] [ str "This is a warning alert — check it out!" ]
Alert.alert [ Alert.Color Info ] [ str "This is a info alert — check it out!" ]
Alert.alert [ Alert.Color Light ] [ str "This is a light alert — check it out!" ]
Alert.alert [ Alert.Color Dark ] [ str "This is a dark alert — check it out!" ]
"""
    ]