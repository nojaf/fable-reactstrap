namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Navbar =

    type NavbarProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("light")>] Light of bool
        | [<CompiledName("dark")>] Dark of bool
        | [<CompiledName("fixed")>] Fixed of string
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("role")>] Role of string
        | [<CompiledName("expand")>] Expand of U2<bool,string>

    let navbar (props: NavbarProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Navbar" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems