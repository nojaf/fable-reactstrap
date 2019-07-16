#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Carousel.fs"
#load "../../src/CarouselItem.fs"
#load "../../src/CarouselCaption.fs"
#load "../../src/CarouselIndicators.fs"
#load "../../src/CarouselControl.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open ReactStrap

let private items =
    [| { Src =
             "data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%22800%22%20height%3D%22400%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20800%20400%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_15ba800aa1d%20text%20%7B%20fill%3A%23555%3Bfont-weight%3Anormal%3Bfont-family%3AHelvetica%2C%20monospace%3Bfont-size%3A40pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_15ba800aa1d%22%3E%3Crect%20width%3D%22800%22%20height%3D%22400%22%20fill%3D%22%23777%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%22285.921875%22%20y%3D%22218.3%22%3EFirst%20slide%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E"
         AltText = "Slide 1"
         Caption = "Slide 1" }
       { Src =
             "data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%22800%22%20height%3D%22400%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20800%20400%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_15ba800aa20%20text%20%7B%20fill%3A%23444%3Bfont-weight%3Anormal%3Bfont-family%3AHelvetica%2C%20monospace%3Bfont-size%3A40pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_15ba800aa20%22%3E%3Crect%20width%3D%22800%22%20height%3D%22400%22%20fill%3D%22%23666%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%22247.3203125%22%20y%3D%22218.3%22%3ESecond%20slide%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E"
         AltText = "Slide 2"
         Caption = "Slide 2" }
       { Src =
             "data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%22800%22%20height%3D%22400%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20800%20400%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_15ba800aa21%20text%20%7B%20fill%3A%23333%3Bfont-weight%3Anormal%3Bfont-family%3AHelvetica%2C%20monospace%3Bfont-size%3A40pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_15ba800aa21%22%3E%3Crect%20width%3D%22800%22%20height%3D%22400%22%20fill%3D%22%23555%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%22277%22%20y%3D%22218.3%22%3EThird%20slide%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E"
         AltText = "Slide 3"
         Caption = "Slide 3" } |]

let private itemLength = Array.length items

let private carouselSample =
    FunctionComponent.Of<obj>(fun _ ->
        let activeIndex = Hooks.useState(0)
        let mutable animating = false // I'm following the example on https://reactstrap.github.io/components/carousel/#app

        let onExiting _ = animating <- true
        let onExited _ = animating <- false

        let next _ =
            if not animating then
                activeIndex.update((activeIndex.current + 1) % itemLength)

        let prev _ =
            if not animating then
                activeIndex.update((activeIndex.current - 1) % itemLength)

        let gotoIndex (newIndex:int) =
            if not animating then
                activeIndex.update(newIndex)

        let slides =
            items
            |> Array.map (fun item ->
                CarouselItem.carouselItem [CarouselItem.OnExiting onExiting; CarouselItem.OnExited onExited; CarouselItem.Custom [Key item.Src]] [
                    img [Src item.Src; Alt item.AltText]
                    CarouselCaption.carouselCaption [CarouselCaption.CaptionText item.Caption; CarouselCaption.CaptionHeader item.Caption] []
                ])

        Carousel.carousel [Carousel.ActiveIndex activeIndex.current; Carousel.Next next; Carousel.Previous prev] [
            CarouselIndicators.carouselIndicators [
                CarouselIndicators.Items items; CarouselIndicators.OnClickHandler gotoIndex
                CarouselIndicators.ActiveIndex activeIndex.current
            ] []
            ofArray slides
            CarouselControl.carouselControl [CarouselControl.Direction CarouselControl.CarouselDirection.Prev
                                             CarouselControl.DirectionText "Previous"
                                             CarouselControl.OnClickHandler prev] []
            CarouselControl.carouselControl [CarouselControl.Direction CarouselControl.CarouselDirection.Next
                                             CarouselControl.DirectionText "Next"
                                             CarouselControl.OnClickHandler next] []
        ]
    ,"CarouselSample")

exportDefault carouselSample