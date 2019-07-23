#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Collapse.fs"
#load "../../src/Button.fs"
#load "../../src/Card.fs"
#load "../../src/CardBody.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private collapseSample =
    FunctionComponent.Of<obj>((fun _ ->
        let toggle = Hooks.useState(false)

        div [] [
            Button.button [
                Button.Color Color.Primary
                Button.Custom [ClassName "mb-4"; OnClick (fun _ -> toggle.update(not toggle.current))]
            ] [str "Toggle"]
            Collapse.collapse [Collapse.IsOpen toggle.current] [
                Card.card [] [
                    CardBody.cardBody [] [
                        str """
Anim pariatur cliche reprehenderit,
enim eiusmod high life accusamus terry richardson ad squid. Nihil
anim keffiyeh helvetica, craft beer labore wes anderson cred
nesciunt sapiente ea proident.
"""
                    ]
                ]
            ]
        ]
    )
    , "CollapseSample")

exportDefault collapseSample
