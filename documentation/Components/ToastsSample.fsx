#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Fade.fs"
#load "../../src/Toast.fs"
#load "../../src/ToastHeader.fs"
#load "../../src/ToastBody.fs"
#load "../../src/Button.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private toastsSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            let showToast = Hooks.useState (false)

            let toggleShowToast =
                fun _ -> showToast.update (not showToast.current)

            fragment [] [
                div [] [
                    div [ ClassName "p-3 my-2 rounded" ] [
                        Toast.toast [] [
                            ToastHeader.toastHeader [] [
                                str "Reactstrap"
                            ]
                            ToastBody.toastBody [] [
                                str "This is a toast on a white background — check it out!"
                            ]
                        ]
                    ]
                    div [ ClassName "p-3 my-2 rounded bg-docs-transparent-grid" ] [
                        Toast.toast [] [
                            ToastHeader.toastHeader [] [
                                str "Reactstrap"
                            ]
                            ToastBody.toastBody [] [
                                str "This is a toast on a gridded background — check it out!"
                            ]
                        ]
                    ]
                    div [ ClassName "p-3 bg-primary my-2 rounded" ] [
                        Toast.toast [] [
                            ToastHeader.toastHeader [] [
                                str "Reactstrap"
                            ]
                            ToastBody.toastBody [] [
                                str "This is a toast on a primary background — check it out!"
                            ]
                        ]
                    ]
                    div [ ClassName "p-3 bg-secondary my-2 rounded" ] [
                        Toast.toast [] [
                            ToastHeader.toastHeader [] [
                                str "Reactstrap"
                            ]
                            ToastBody.toastBody [] [
                                str "This is a toast on a secondary background — check it out!"
                            ]
                        ]
                    ]
                    div [ ClassName "p-3 bg-success my-2 rounded" ] [
                        Toast.toast [] [
                            ToastHeader.toastHeader [] [
                                str "Reactstrap"
                            ]
                            ToastBody.toastBody [] [
                                str "This is a toast on a success background — check it out!"
                            ]
                        ]
                    ]
                    div [ ClassName "p-3 bg-danger my-2 rounded" ] [
                        Toast.toast [] [
                            ToastHeader.toastHeader [] [
                                str "Reactstrap"
                            ]
                            ToastBody.toastBody [] [
                                str "This is a toast on a danger background — check it out!"
                            ]
                        ]
                    ]
                    div [ ClassName "p-3 bg-warning my-2 rounded" ] [
                        Toast.toast [] [
                            ToastHeader.toastHeader [] [
                                str "Reactstrap"
                            ]
                            ToastBody.toastBody [] [
                                str "This is a toast on a warning background — check it out!"
                            ]
                        ]
                    ]
                    div [ ClassName "p-3 bg-info my-2 rounded" ] [
                        Toast.toast [] [
                            ToastHeader.toastHeader [] [
                                str "Reactstrap"
                            ]
                            ToastBody.toastBody [] [
                                str "This is a toast on an info background — check it out!"
                            ]
                        ]
                    ]
                    div [ ClassName "p-3 bg-dark my-2 rounded" ] [
                        Toast.toast [] [
                            ToastHeader.toastHeader [] [
                                str "Reactstrap"
                            ]
                            ToastBody.toastBody [] [
                                str "This is a toast on a dark background — check it out!"
                            ]
                        ]
                    ]
                    div [ ClassName "p-3 my-2 rounded"
                          Style [ Background "black" ] ] [
                        Toast.toast [] [
                            ToastHeader.toastHeader [] [
                                str "Reactstrap"
                            ]
                            ToastBody.toastBody [] [
                                str "This is a toast on a black background — check it out!"
                            ]
                        ]
                    ]
                ]
                div [] [
                    Button.button [ Button.Color Primary
                                    Button.Custom [ OnClick toggleShowToast ] ] [
                        str "Show toast"
                    ]
                    br []
                    br []
                    Toast.toast [ Toast.IsOpen showToast.current ] [
                        ToastHeader.toastHeader [ ToastHeader.Toggle toggleShowToast ] [
                            str "Toast title"
                        ]
                        ToastBody.toastBody [] [
                            str
                                "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                        ]
                    ]
                ]
            ]),
         "ToastsSample")

exportDefault toastsSample
