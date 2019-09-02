#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Media.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let custom attr =
    attr
    |>  Media.Custom

let private mediaSample =
    FunctionComponent.Of<obj>
        ((fun _ -> fragment [] [
            Media.media [ ]
                [ Media.media [
                        Media.Custom [ HTMLAttr.Custom ("left", true) ]
                        Media.Custom [ Href "#" ]
                      ]
                    [ Media.media [
                            Media.Custom [ HTMLAttr.Custom ("object", true) ]
                            Media.Custom [ HTMLAttr.Custom ("src", "data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%2264%22%20height%3D%2264%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%2064%2064%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_16cf3a03a19%20text%20%7B%20fill%3A%23AAAAAA%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A10pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_16cf3a03a19%22%3E%3Crect%20width%3D%2264%22%20height%3D%2264%22%20fill%3D%22%23EEEEEE%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%2213.4609375%22%20y%3D%2236.4015625%22%3E64x64%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E") ]
                            Media.Custom [ Alt "Generic placeholder image" ]
                        ]
                        [ ]
                    ]
                  Media.media [
                       Media.Custom [HTMLAttr.Custom ("body", true)]
                      ]
                    [ Media.media [
                        Media.Custom [HTMLAttr.Custom ("heading", true)]
                        ]
                        [ str "Media heading" ]
                      str "Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus."
                    ]

                ]
        ]), "MediaSample")

exportDefault mediaSample
