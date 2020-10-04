#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Spinner.fs"

open Fable.Core.JsInterop
open Fable.React
open Reactstrap

let private spinnersSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            fragment [] [
                Spinner.spinner [ Spinner.Color Primary ] []
                Spinner.spinner [ Spinner.Color Secondary ] []
                Spinner.spinner [ Spinner.Color Success ] []
                Spinner.spinner [ Spinner.Color Danger ] []
                Spinner.spinner [ Spinner.Color Warning ] []
                Spinner.spinner [ Spinner.Color Info ] []
                Spinner.spinner [ Spinner.Color Light ] []
                Spinner.spinner [ Spinner.Color Dark ] []
                br []
                Spinner.spinner [ Spinner.Type "grow"
                                  Spinner.Color Primary ] []
                Spinner.spinner [ Spinner.Type "grow"
                                  Spinner.Color Secondary ] []
                Spinner.spinner [ Spinner.Type "grow"
                                  Spinner.Color Success ] []
                Spinner.spinner [ Spinner.Type "grow"
                                  Spinner.Color Danger ] []
                Spinner.spinner [ Spinner.Type "grow"
                                  Spinner.Color Warning ] []
                Spinner.spinner [ Spinner.Type "grow"
                                  Spinner.Color Info ] []
                Spinner.spinner [ Spinner.Type "grow"
                                  Spinner.Color Light ] []
                Spinner.spinner [ Spinner.Type "grow"
                                  Spinner.Color Dark ] []
            ]),
         "SpinnersSample")

exportDefault spinnersSample
