#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Popover.fs"
#load "../../src/PopoverHeader.fs"
#load "../../src/PopoverBody.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private popoversSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
        let showPopover = Hooks.useState(false)
        let toggleShowPopover = fun _ -> showPopover.update(not showPopover.current)
        fragment []
            [
            button [ Id "Popover1"
                     Type "button" ]
                [ str "Launch Popover" ]
            Popover.popover
                [
                    Popover.Placement Bottom
                    // HTMLAttr.Custom ("placement", "bottom")
                    // HTMLAttr.Custom ("isopen", "{this.state.popoverOpen}")
                    Popover.IsOpen showPopover.current
                    Popover.Target !^ "Popover1"
                    Popover.Toggle toggleShowPopover
                        // HTMLAttr.Custom ("toggle", "{this.toggle}")
                        ]
                [ PopoverHeader.popoverHeader [ ]
                    [ str "Popover Title" ]
                  PopoverBody.popoverBody [ ]
                    [ str "Sed posuere consectetur est at lobortis. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum." ] ]
            ]), "PopoversSample")

exportDefault popoversSample
