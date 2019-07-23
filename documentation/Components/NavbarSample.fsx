#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Nav.fs"
#load "../../src/NavItem.fs"
#load "../../src/NavLink.fs"
#load "../../src/Navbar.fs"
#load "../../src/NavbarBrand.fs"
#load "../../src/NavbarToggler.fs"
#load "../../src/Collapse.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private navbarSample =
    FunctionComponent.Of<obj>(
        (fun _ ->

        let toggle = Hooks.useState(false)

        div [] [
            Navbar.navbar [Navbar.Color Color.Light; Navbar.Light true; Navbar.Expand (!^ Size.Md)] [
                NavbarBrand.navbarBrand [NavbarBrand.Custom [Href "/"]] [str "reactstrap"]
                NavbarToggler.navbarToggler [NavbarToggler.Custom [OnClick (fun _ -> toggle.update(not toggle.current))]] []
                Collapse.collapse [Collapse.IsOpen toggle.current; Collapse.Navbar true] [
                    Nav.nav [Nav.Navbar true;Nav.Custom [ClassName "ml-auto"]] [
                        NavItem.navItem [] [
                            NavLink.navLink [NavLink.Custom [Href "/components"]] [str "Components"]
                        ]
                        NavItem.navItem [] [
                            NavLink.navLink [NavLink.Custom [Href "https://github.com"]] [str "GitHub"]
                        ]
                    ]
                ]
        ]
]), "NavbarSample")

exportDefault navbarSample
