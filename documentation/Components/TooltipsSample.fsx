#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Tooltip.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private tooltipsSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
        let showTooltip = Hooks.useState(false);
        let toggleToolTip = fun _ -> showTooltip.update (not showTooltip.current)
        fragment []
            [
                p [ ]
                    [ str "Somewhere in here is a "
                      span [
                             Style [ CSSProp.TextDecoration "underline"; CSSProp.Color "blue" ]
                             Href "#"
                             Id "TooltipExample" ]
                        [ str "tooltip" ]
                      str "." ]
                Tooltip.tooltip [
                    Tooltip.Placement Right
                    Tooltip.IsOpen showTooltip.current
                    Tooltip.Toggle toggleToolTip
                    Tooltip.Target !^"TooltipExample" ]
                    [ str "Hello world!" ]
            ]), "TooltipsSample")

exportDefault tooltipsSample
