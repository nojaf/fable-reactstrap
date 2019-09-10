#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Fade.fs"
#load "../../src/Modal.fs"
#load "../../src/ModalHeader.fs"
#load "../../src/ModalBody.fs"
#load "../../src/ModalFooter.fs"
#load "../../src/Button.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private modalsSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            let showModal = Hooks.useState(false)
            let toggle = fun _ -> showModal.update(not showModal.current)

            div [ ]
                [ Button.button [
                       Button.Color Danger
                       Button.Custom [ OnClick toggle ]
                    ]
                    [ str "Launch Modal" ]

                  Modal.modal [
                      Modal.IsOpen showModal.current
                    ]
                    [ ModalHeader.modalHeader [
                            ModalHeader.Toggle toggle
                        ]
                        [ str "Modal title" ]
                      ModalBody.modalBody [ ]
                        [ str "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." ]
                      ModalFooter.modalFooter [ ]
                        [ Button.button [
                              Button.Color Primary
                              Button.Custom [ OnClick toggle ]
                            ]
                            [ str "Do Something" ]
                          Button.button [
                              Button.Color Secondary
                              Button.Custom [ OnClick toggle ]
                            ]
                            [ str "Cancel" ]
                        ]
                    ]
                ]
        ), "ModalsSample")

exportDefault modalsSample
