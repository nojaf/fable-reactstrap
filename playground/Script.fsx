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
    
let alertSample =
    exampleBox [
        Alert.alert [Alert.Color Primary] [ str "This is a primary alert — check it out!" ]
        Alert.alert [Alert.Color Info] [ str "This is a secondary alert — check it out!" ]
        Alert.alert [Alert.Color Success] [ str "This is a success alert — check it out!" ]
        Alert.alert [Alert.Color Danger] [ str "This is a danger alert — check it out!" ]
        Alert.alert [Alert.Color Warning] [ str "This is a warning alert — check it out!" ]
        Alert.alert [Alert.Color Info] [ str "This is a info alert — check it out!" ]
        Alert.alert [Alert.Color Light] [ str "This is a light alert — check it out!" ]
        Alert.alert [Alert.Color Dark] [ str "This is a dark alert — check it out!" ]
    ]
    
let badgeSample =
    exampleBox [
        h3 [] [
            str "Heading "
            Badge.badge [Badge.Color Secondary] [str "New"]    
        ]
        Badge.badge [Badge.Color Warning] [str "oh my"]
        Badge.badge [Badge.Color Dark; Badge.ClassName "ml-1"] [str "dark"]
        Badge.badge [Badge.ClassName "ml-1"] [str "badges"]
        div [] [
            Badge.badge [Badge.Color Info; Badge.Pill] [str "pill"]
        ]
        div [] [
            Badge.badge [Badge.Color Danger; Badge.Href "https://nojaf.com"] [str "with link"]
        ]
    ]

let breadcrumbsSample =
    exampleBox [
        Breadcrumb.breadcrumb [] [
            BreadcrumbItem.breadcrumbItem [BreadcrumbItem.Active true] [str "Home"]
        ]
        Breadcrumb.breadcrumb [] [
            BreadcrumbItem.breadcrumbItem [] [
                a [Href "#"] [ str "Home"]
            ]
            BreadcrumbItem.breadcrumbItem [BreadcrumbItem.Active true] [
                str "Library"
            ]
        ]
        Breadcrumb.breadcrumb [] [
            BreadcrumbItem.breadcrumbItem [] [
                a [Href "#"] [ str "Home"]
            ]
            BreadcrumbItem.breadcrumbItem [] [
                a [Href "#"] [ str "Library"]
            ]
            BreadcrumbItem.breadcrumbItem [BreadcrumbItem.Active true] [
                str "Data"
            ]
        ]
        p [] [str "No list" ]
        Breadcrumb.breadcrumb [Breadcrumb.Tag "nav"; Breadcrumb.ListTag "div"] [
            BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Tag "a"; BreadcrumbItem.Href "#"] [
                str "Home"
            ]
            BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Tag "a"; BreadcrumbItem.Href "#"] [
                str "Library"
            ]
            BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Tag "a"; BreadcrumbItem.Href "#"] [
                str "Data"
            ]
            BreadcrumbItem.breadcrumbItem [ BreadcrumbItem.Tag "span"; BreadcrumbItem.Active true] [
                str "Bootstrap"
            ]
        ]
        prismCode """

"""
    ]
    
let buttonSample =
    exampleBox [
        div [] [
            Button.button [Button.Color Primary; Button.ClassName "mr-1"] [str "primary"]
            Button.button [Button.Color Secondary; Button.ClassName "mr-1"] [str "secondary"]
            Button.button [Button.Color Success; Button.ClassName "mr-1"] [str "success"]
            Button.button [Button.Color Info; Button.ClassName "mr-1"] [str "info"]
            Button.button [Button.Color Warning; Button.ClassName "mr-1"] [str "warning"]
            Button.button [Button.Color Danger; Button.ClassName "mr-1"] [str "danger"]
            Button.button [Button.Color Link; Button.ClassName "mr-1"] [str "link"]
        ]
        div [ClassName "mt-2 mb-2"] [
            h5 [] [str "Outline"]
            Button.button [Button.Color Primary; Button.Outline true; Button.ClassName "mr-1"] [str "primary"]
            Button.button [Button.Color Secondary; Button.Outline true; Button.ClassName "mr-1"] [str "secondary"]
            Button.button [Button.Color Success; Button.Outline true; Button.ClassName "mr-1"] [str "success"]
            Button.button [Button.Color Info; Button.Outline true; Button.ClassName "mr-1"] [str "info"]
            Button.button [Button.Color Warning; Button.Outline true; Button.ClassName "mr-1"] [str "warning"]
            Button.button [Button.Color Danger; Button.Outline true; Button.ClassName "mr-1"] [str "danger"]
        ]
        div [ClassName "mt-2 mb-2"] [
            h5 [ ] [str "Sizes"]
            Button.button [Button.Color Primary; Button.Size Lg; Button.ClassName "mr-1"] [str "Large button"]
            Button.button [Button.Color Secondary; Button.Size Lg; Button.ClassName "mr-1"] [str "Large button"]
            Button.button [Button.Color Primary; Button.Size Sm; Button.ClassName "mr-1"] [str "Small button"]
            Button.button [Button.Color Secondary; Button.Size Sm; Button.ClassName "mr-1"] [str "Small button"]
            Button.button [Button.Color Primary; Button.Block true; Button.ClassName "mt-2"] [str "Block level button"]
        ]
        div [ClassName "mt-2 mb-2"] [
            h5 [] [str "Active & disabled"]
            Button.button [Button.Color Primary; Button.ClassName "mr-1"; Button.Active true] [str "primary"]
            Button.button [Button.Color Primary; Button.ClassName "mr-1"; Button.Disabled true] [str "primary"]
        ]
        div [ClassName "mt-2 mb-2"] [
            h5 [] [str "Close icon"]
            div [] [
                span [] [str "Default close icon"]
                Button.button [Button.Close true] []
            ]
            div [ ClassName "mt-2" ] [
                span [] [str "Custom content"]
                Button.button [Button.Close true] [ span [DangerouslySetInnerHTML { __html = "&dash;" }] [] ]
            ]
        ]
    ]
    
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
    
let buttonGroupSample _ =
    let isOpenState = Hooks.useState(false)
    let isOpenState2 = Hooks.useState(false)
    
    exampleBox [
        ButtonGroup.buttonGroup [] [
            Button.button [] [str "Left"]
            Button.button [] [str "Middle"]
            Button.button [] [str "Right"]
        ]
        h5 [ClassName "mt-2"] [str "Button toolbar"]
        ButtonToolbar.buttonToolbar [] [
            ButtonGroup.buttonGroup [] [
                Button.button [] [ofInt 1]
                Button.button [] [ofInt 2]
                Button.button [] [ofInt 3]
                Button.button [] [ofInt 4]
            ]
            ButtonGroup.buttonGroup [] [
                Button.button [] [ofInt 5]
                Button.button [] [ofInt 6]
                Button.button [] [ofInt 7]
            ]
            ButtonGroup.buttonGroup [] [
                Button.button [] [ofInt 8]
            ]
        ]
        h5 [ClassName "mt-2"] [str "Sizing"]
        ButtonGroup.buttonGroup [ButtonGroup.Size Lg] [
            Button.button [] [str "Left"]
            Button.button [] [str "Middle"]
            Button.button [] [str "Right"]
        ]
        br []
        ButtonGroup.buttonGroup [ButtonGroup.ClassName "mt-2"] [
            Button.button [] [str "Left"]
            Button.button [] [str "Middle"]
            Button.button [] [str "Right"]
        ]
        br []
        ButtonGroup.buttonGroup [ButtonGroup.Size Sm; ButtonGroup.ClassName "mt-2"] [
            Button.button [] [str "Left"]
            Button.button [] [str "Middle"]
            Button.button [] [str "Right"]
        ]
        h5 [ClassName "mt-2"] [str "Nesting"]
        ButtonGroup.buttonGroup [] [
            Button.button [] [ofInt 1]
            Button.button [] [ofInt 2]
            ButtonDropdown.buttonDropdown [ButtonDropdown.IsOpen isOpenState.current; ButtonDropdown.Toggle (fun () -> isOpenState.update(not isOpenState.current))] [
                DropdownToggle.dropdownToggle [DropdownToggle.Caret true] [
                    str "Dropdown"
                ]
                DropdownMenu.dropdownMenu [] [
                    DropdownItem.dropdownItem [] [str "Dropdown link"]
                    DropdownItem.dropdownItem [] [str "Dropdown link"]
                ]
            ]
        ]
        h5 [ClassName "mt-2"] [str "Vertical variation"]
        ButtonGroup.buttonGroup [ButtonGroup.Vertical true] [
            Button.button [] [ofInt 1]
            Button.button [] [ofInt 2]
            ButtonDropdown.buttonDropdown [ButtonDropdown.IsOpen isOpenState2.current; ButtonDropdown.Toggle (fun () -> isOpenState2.update(not isOpenState2.current))] [
                DropdownToggle.dropdownToggle [DropdownToggle.Caret true] [
                    str "Dropdown"
                ]
                DropdownMenu.dropdownMenu [] [
                    DropdownItem.dropdownItem [] [str "Dropdown link"]
                    DropdownItem.dropdownItem [] [str "Dropdown link"]
                ]
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