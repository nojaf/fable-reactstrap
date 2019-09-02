#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/InputGroup.fs"
#load "../../src/InputGroupAddon.fs"
#load "../../src/InputGroupText.fs"
#load "../../src/Input.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private inputGroupSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            fragment []
                [
                    InputGroup.inputGroup [] [
                        InputGroupAddon.inputGroupAddon [
                            InputGroupAddon.AddonType Prepend
                        ] [ str "@"]
                        Input.input [ Input.Placeholder "username"]
                      ]
                    br []
                    InputGroup.inputGroup [] [
                        InputGroupAddon.inputGroupAddon [
                            InputGroupAddon.AddonType Prepend
                        ] [
                            InputGroupText.inputGroupText [] [
                                Input.input [ Input.Addon true; Input.Type Input.Checkbox ]
                            ]
                        ]
                        Input.input [ Input.Placeholder "Check it out"]
                      ]
                    br []
                    InputGroup.inputGroup [] [
                        Input.input [ Input.Placeholder "username"]
                        InputGroupAddon.inputGroupAddon [
                            InputGroupAddon.AddonType Append
                        ] [
                            InputGroupText.inputGroupText [] [
                                str "@example.com"
                            ]
                        ]
                      ]
                    br []
                    InputGroup.inputGroup [] [
                        InputGroupAddon.inputGroupAddon [
                            InputGroupAddon.AddonType Prepend
                        ] [
                            InputGroupText.inputGroupText [] [
                                str "$"
                            ]
                            InputGroupText.inputGroupText [] [
                                str "$"
                            ]
                        ]
                        Input.input [ Input.Placeholder "Dolla dolla billz yo!"]
                        InputGroupAddon.inputGroupAddon [
                            InputGroupAddon.AddonType Append
                        ] [
                            InputGroupText.inputGroupText [] [
                                str "$"
                            ]
                            InputGroupText.inputGroupText [] [
                                str "$"
                            ]
                        ]
                      ]
                    br []
                    InputGroup.inputGroup [] [
                        InputGroupAddon.inputGroupAddon [
                            InputGroupAddon.AddonType Prepend
                        ] [
                            str "$"
                        ]
                        Input.input [
                            Input.Placeholder "Amount"
                            Input.Type Input.Number
                            Input.Min 0
                            Input.Max 100
                          ]
                        InputGroupAddon.inputGroupAddon [
                            InputGroupAddon.AddonType Prepend
                        ] [
                            str ".00"
                        ]
                      ]
                    br []
                ])

        , "InputGroupSample")

exportDefault inputGroupSample
