#load "../.paket/load/netstandard2.0/main.group.fsx"
#load "./HookRouter.fsx"

#if INTERACTIVE
#r "netstandard"
#endif

#load "../src/Common.fs"
#load "../src/Alert.fs"
#load "../src/Badge.fs"
#load "../src/Breadcrumb.fs"
#load "../src/BreadcrumbItem.fs"
#load "../src/Button.fs"
#load "../src/ButtonDropdown.fs"
#load "../src/DropdownToggle.fs"
#load "../src/DropdownMenu.fs"
#load "../src/DropdownItem.fs"
#load "../src/ButtonGroup.fs"
#load "../src/ButtonToolbar.fs"
#load "../src/Card.fs"
#load "../src/CardBody.fs"
#load "../src/CardColumns.fs"
#load "../src/CardDeck.fs"
#load "../src/CardFooter.fs"
#load "../src/CardGroup.fs"
#load "../src/CardHeader.fs"
#load "../src/CardImg.fs"
#load "../src/CardImgOverlay.fs"
#load "../src/CardLink.fs"
#load "../src/CardSubtitle.fs"
#load "../src/CardText.fs"
#load "../src/CardTitle.fs"
#load "../src/Carousel.fs"
#load "../src/CarouselCaption.fs"
#load "../src/CarouselControl.fs"
#load "../src/CarouselIndicators.fs"
#load "../src/CarouselItem.fs"
#load "../src/Col.fs"
#load "../src/Collapse.fs"
#load "../src/Container.fs"
#load "../src/CustomInput.fs"
#load "../src/Dropdown.fs"
#load "../src/Fade.fs"
#load "../src/Form.fs"
#load "../src/FormFeedback.fs"
#load "../src/FormGroup.fs"
#load "../src/FormText.fs"
#load "../src/Input.fs"
#load "../src/InputGroup.fs"
#load "../src/InputGroupAddon.fs"
#load "../src/InputGroupButtonDropdown.fs"
#load "../src/InputGroupText.fs"
#load "../src/Jumbotron.fs"
#load "../src/Label.fs"
#load "../src/ListGroup.fs"
#load "../src/ListGroupItem.fs"
#load "../src/ListGroupItemHeading.fs"
#load "../src/ListGroupItemText.fs"
#load "../src/Media.fs"
#load "../src/Modal.fs"
#load "../src/ModalBody.fs"
#load "../src/ModalFooter.fs"
#load "../src/ModalHeader.fs"
#load "../src/Nav.fs"
#load "../src/NavItem.fs"
#load "../src/NavLink.fs"
#load "../src/Navbar.fs"
#load "../src/NavbarBrand.fs"
#load "../src/NavbarToggler.fs"
#load "../src/Pagination.fs"
#load "../src/PaginationItem.fs"
#load "../src/PaginationLink.fs"
#load "../src/Popover.fs"
#load "../src/PopoverBody.fs"
#load "../src/PopoverHeader.fs"
#load "../src/Progress.fs"
#load "../src/Row.fs"
#load "../src/Spinner.fs"
#load "../src/TabContent.fs"
#load "../src/TabPane.fs"
#load "../src/Table.fs"
#load "../src/Tag.fs"
#load "../src/Toast.fs"
#load "../src/ToastBody.fs"
#load "../src/ToastHeader.fs"
#load "../src/Tooltip.fs"

open System
open Fable.Core.JsInterop
open Fable.React
open ReactStrap
open Fable.React.Props
open HookRouter
open Browser

importSideEffects "./style.sass"

let private exampleBox children = div [ClassName "docs-example"] children
let private exampleTitle title = h2 [ClassName "h3"] [str title]
    


    
let buttonDropdown _ =
    let isOpenState = Hooks.useState(false)
    let isOpenState2 = Hooks.useState(false)
    let isOpenState3 = Hooks.useState(false)
    
    exampleBox [
        ButtonDropdown.buttonDropdown [ButtonDropdown.IsOpen isOpenState.current; ButtonDropdown.Toggle (fun () -> isOpenState.update(not isOpenState.current))] [
            DropdownToggle.dropdownToggle [DropdownToggle.Caret true] [str "Button Dropdown"]
            DropdownMenu.dropdownMenu [] [
                DropdownItem.dropdownItem [DropdownItem.Header true] [str "Header"]
                DropdownItem.dropdownItem [DropdownItem.Disabled true] [str "Action"]
                DropdownItem.dropdownItem [] [str "Another Action"]
                DropdownItem.dropdownItem [DropdownItem.Divider true] []
                DropdownItem.dropdownItem [] [str "Another Action"]
            ]
        ]
        h5 [ClassName "mt-2"] [str "Split button dropdowns"]
        ButtonDropdown.buttonDropdown [ButtonDropdown.IsOpen isOpenState2.current; ButtonDropdown.Toggle (fun () -> isOpenState2.update(not isOpenState2.current))] [
            Button.button [Button.Color Primary] [str "primary"]
            DropdownToggle.dropdownToggle [DropdownToggle.Caret true; DropdownToggle.Color Primary] []
            DropdownMenu.dropdownMenu [] [
                DropdownItem.dropdownItem [DropdownItem.Header true] [str "Header"]
                DropdownItem.dropdownItem [DropdownItem.Disabled true] [str "Action"]
                DropdownItem.dropdownItem [] [str "Another Action"]
            ]
        ]
        h5 [ClassName "mt-2"] [str "Sizing"]
        ButtonDropdown.buttonDropdown [ButtonDropdown.IsOpen isOpenState3.current; ButtonDropdown.Toggle (fun () -> isOpenState3.update(not isOpenState3.current))] [
            DropdownToggle.dropdownToggle [DropdownToggle.Caret true; DropdownToggle.Size Lg] [
                str "Large Button"
            ]
            DropdownMenu.dropdownMenu [] [
                DropdownItem.dropdownItem [] [str "Another action"]
                DropdownItem.dropdownItem [] [str "Another action"]
            ]
        ]
    ]
    

    
let cardSample =
    exampleBox [
        Card.card [Card.ClassName "w-50"] [
            CardImg.cardImg [CardImg.Top true; CardImg.Src "http://lorempixel.com/400/200/"] []
            CardBody.cardBody [] [
                CardTitle.cardTitle [CardTitle.Tag "h5"] [str "Card title"]
                CardSubtitle.cardSubtitle [CardSubtitle.Tag "h6"; CardSubtitle.ClassName "mb-1"] [str "Card subtitle"]
                CardText.cardText [] [str "Some quick example text to build on the card title and make up the bulk of the card's content."]
                Button.button [Button.Color Primary] [str "Button"]
            ]
        ]
        h5 [ClassName "mt-2"] [str "Header and Footer"]
        Card.card [] [
            CardHeader.cardHeader [] [str "Header"]
            CardBody.cardBody [] [
                CardTitle.cardTitle [] [str "Special Title Treatment"]
                CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
                Button.button [] [str "Go somewhere"]
            ]
            CardFooter.cardFooter [] [str "Footer"]
        ]
        h5 [ClassName "mt-2"] [str "Background variants"]
        Card.card [Card.Body true; Card.Inverse true; Card.ClassName "w-50"; Card.Style [BackgroundColor "#333"; BorderColor "#333"]] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        Card.card [Card.Body true; Card.Inverse true; Card.Color Primary; Card.ClassName "w-50"] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        Card.card [Card.Body true; Card.Inverse true; Card.Color Success; Card.ClassName "w-50"] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        Card.card [Card.Body true; Card.Inverse true; Card.Color Info; Card.ClassName "w-50"] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        Card.card [Card.Body true; Card.Inverse true; Card.Color Warning; Card.ClassName "w-50"] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        Card.card [Card.Body true; Card.Inverse true; Card.Color Danger; Card.ClassName "w-50"] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        h5 [ClassName "mt-2"] [str "Outline variants"]
        Card.card [Card.Body true; Card.Color Primary; Card.ClassName "w-50"; Card.Outline true] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        Card.card [Card.Body true; Card.Color Success; Card.ClassName "w-50"; Card.Outline true] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        Card.card [Card.Body true; Card.Color Info; Card.ClassName "w-50"; Card.Outline true] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        Card.card [Card.Body true; Card.Color Warning; Card.ClassName "w-50"; Card.Outline true] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        Card.card [Card.Body true; Card.Color Danger; Card.ClassName "w-50"; Card.Outline true] [
            CardTitle.cardTitle [] [str "Special Title Treatment"]
            CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
            Button.button [] [str "Button"]
        ]
        h5 [ClassName "mt-2"] [str "Groups"]
        CardGroup.cardGroup [] [
            Card.card [] [
                CardImg.cardImg [CardImg.Top true; CardImg.Width "100%"; CardImg.Src "http://lorempixel.com/400/200/"] []
                CardBody.cardBody [] [
                    CardTitle.cardTitle [] [str "Card title"]
                    CardSubtitle.cardSubtitle [] [str "Card subtitle"]
                    CardText.cardText [] [str "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer."]
                    Button.button [] [str "Button"]
                ]
            ]
            Card.card [] [
                CardImg.cardImg [CardImg.Top true; CardImg.Width "100%"; CardImg.Src "http://lorempixel.com/400/200/"] []
                CardBody.cardBody [] [
                    CardTitle.cardTitle [] [str "Card title"]
                    CardSubtitle.cardSubtitle [] [str "Card subtitle"]
                    CardText.cardText [] [str "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer."]
                    Button.button [] [str "Button"]
                ]
            ]
            Card.card [] [
                CardImg.cardImg [CardImg.Top true; CardImg.Width "100%"; CardImg.Src "http://lorempixel.com/400/200/"] []
                CardBody.cardBody [] [
                    CardTitle.cardTitle [] [str "Card title"]
                    CardSubtitle.cardSubtitle [] [str "Card subtitle"]
                    CardText.cardText [] [str "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer."]
                    Button.button [] [str "Button"]
                ]
            ]
        ]
        h5 [ClassName "mt-2"] [str "Decks"]
        CardDeck.cardDeck [] [
            Card.card [] [
                CardImg.cardImg [CardImg.Top true; CardImg.Width "100%"; CardImg.Src "http://lorempixel.com/400/200/"] []
                CardBody.cardBody [] [
                    CardTitle.cardTitle [] [str "Card title"]
                    CardSubtitle.cardSubtitle [] [str "Card subtitle"]
                    CardText.cardText [] [str "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer."]
                    Button.button [] [str "Button"]
                ]
            ]
            Card.card [] [
                CardImg.cardImg [CardImg.Top true; CardImg.Width "100%"; CardImg.Src "http://lorempixel.com/400/200/"] []
                CardBody.cardBody [] [
                    CardTitle.cardTitle [] [str "Card title"]
                    CardSubtitle.cardSubtitle [] [str "Card subtitle"]
                    CardText.cardText [] [str "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer."]
                    Button.button [] [str "Button"]
                ]
            ]
            Card.card [] [
                CardImg.cardImg [CardImg.Top true; CardImg.Width "100%"; CardImg.Src "http://lorempixel.com/400/200/"] []
                CardBody.cardBody [] [
                    CardTitle.cardTitle [] [str "Card title"]
                    CardSubtitle.cardSubtitle [] [str "Card subtitle"]
                    CardText.cardText [] [str "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer."]
                    Button.button [] [str "Button"]
                ]
            ]
        ]
        h5 [ClassName "mt-2"] [str "Columns"]
        CardColumns.cardColumns [] [
            Card.card [] [
                CardImg.cardImg [CardImg.Top true; CardImg.Width "100%"; CardImg.Src "http://lorempixel.com/400/200/"] []
                CardBody.cardBody [] [
                    CardTitle.cardTitle [] [str "Card title"]
                    CardSubtitle.cardSubtitle [] [str "Card subtitle"]
                    CardText.cardText [] [str "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer."]
                    Button.button [] [str "Button"]
                ]
            ]
            Card.card [] [
                CardImg.cardImg [CardImg.Top true; CardImg.Width "100%"; CardImg.Src "http://lorempixel.com/400/200/"] []
            ]
            Card.card [] [
                CardImg.cardImg [CardImg.Top true; CardImg.Width "100%"; CardImg.Src "http://lorempixel.com/400/200/"] []
                CardBody.cardBody [] [
                    CardTitle.cardTitle [] [str "Card title"]
                    CardSubtitle.cardSubtitle [] [str "Card subtitle"]
                    CardText.cardText [] [str "This card has supporting text below as a natural lead-in to additional content."]
                    Button.button [] [str "Button"]
                ]
            ]
            Card.card [Card.Body true; Card.Inverse true; Card.Style [BackgroundColor "#333"; BorderColor "#333"]] [
                CardTitle.cardTitle [] [str "Special Title Treatment"]
                CardText.cardText [] [str "With supporting text below as a natural lead-in to additional content."]
                Button.button [] [str "Button"]
            ]
            Card.card [] [
                CardImg.cardImg [CardImg.Top true; CardImg.Width "100%"; CardImg.Src "http://lorempixel.com/400/200/"] []
                CardBody.cardBody [] [
                    CardTitle.cardTitle [] [str "Card title"]
                    CardSubtitle.cardSubtitle [] [str "Card subtitle"]
                    CardText.cardText [] [str "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer."]
                    Button.button [] [str "Button"]
                ]
            ]
            Card.card [Card.Body true; Card.Inverse true; Card.Color Primary] [
                CardTitle.cardTitle [] [str "Special Title Treatment"]
                CardText.cardText [] [str "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer."]
                Button.button [] [str "Button"]
            ]
        ]
    ]

let combined =
    fragment [] [

    ]
    
let routes =
    createObj [
        "/components/alerts" ==> fun _ -> alertSample
        "/components/badge" ==> fun _ -> badgeSample
    ]
    
let routeUrls = Fable.Core.JS.Object.keys(routes)

let NotFoundPage =
    div [ ]
        [ section [ ClassName "jumbotron text-center mb-3" ]
            [ div [ ClassName "container" ]
                [ div [ ClassName "row" ]
                    [ div [ ClassName "col" ]
                        [ p [ ClassName "lead" ]
                            [ img [ Src "/assets/logo.png"
                                    Alt ""
                                    HTMLAttr.Width "150px" ] ]
                          h1 [ ClassName "jumbotron-heading display-4" ]
                            [ str "404 - Not Found" ]
                          p [ ClassName "lead" ]
                            [ str "Can't find what you're looking for?"
                              br []
                              a [ Href "https://github.com/nojaf/fablereactstrap/issues/new" ] [ str "Open up an issue." ]
                            ]
                           ] ] ] ] ]

let App =
    FunctionComponent.Of (fun _ ->
        useRedirect "/" "/components/alerts" None (Some false)
        useRedirect "/components" "/components/alerts" None (Some false)
        let routeResults = useRoutes routes
        let path = usePath()
        
        let menuItems =
            routeUrls
            |> Seq.map (fun url ->
                let className = if url = path then "nav-link active" else "nav-link"
                let text =
                    url.Replace("/components/", "").Split('-')
                    |> Array.map (fun word -> String.Concat(System.Char.ToUpper(word.[0]), word.Substring(1)))
                    |> String.concat " "
                
                li [ClassName "nav-item"] [
                    A [ AProps.ClassName className; AProps.Href url] [str text]
                ]
            )

        match routeResults with
        | Some r ->
            div [ ClassName "container content" ] [
                div [ClassName "row"] [
                    main [ClassName "col-md-3 order-md-2"] [
                        div [ClassName "mb-3 docs-sidebar"] [
                            h1 [ClassName "h5"] [str "Components"]
                            ul [ClassName "flex-column nav"] menuItems
                        ]
                    ]
                    aside [ClassName "col-md-9 order-md-1"] [
                        r
                    ]
                ]
            ]
        | None -> NotFoundPage

    , "App")


let app = document.getElementById "app"
ReactDom.render(App(), app)