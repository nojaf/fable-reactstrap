#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Form.fs"
#load "../../src/FormGroup.fs"
#load "../../src/Input.fs"
#load "../../src/Button.fs"
#load "../../src/Label.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap
open Browser.Types

type FormValues =
    { Email: string
      Password: string }

let private formSample =
    FunctionComponent.Of<obj>((fun _ ->
        let state = Hooks.useState({ Email = ""; Password = "" })

        let onSubmit (ev:Event) =
            ev.preventDefault()
            printfn "Form values: %A" state.current

        Form.form [Form.Custom [OnSubmit onSubmit]] [
            FormGroup.formGroup [] [
                Label.label [] [str "Email"]
                Input.input [Input.Type Input.Email; Input.Custom [OnChange (fun ev -> { state.current with Email = ev.Value } |> state.update )]]
            ]
            FormGroup.formGroup [] [
                Label.label [] [str "Password"]
                Input.input [Input.Type Input.Password ;Input.Custom [OnChange (fun ev -> { state.current with Password = ev.Value } |> state.update )]]
            ]
            Button.button [Button.Color Common.Primary] [str "Submit"]
        ]), "FormSample")

exportDefault formSample
