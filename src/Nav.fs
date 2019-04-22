namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Nav =

    type NavProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tabs")>] Tabs of bool
        | [<CompiledName("pills")>] Pills of bool
        | [<CompiledName("card")>] Card of bool
        | [<CompiledName("justified")>] Justified of bool
        | [<CompiledName("fill")>] Fill of bool
        | [<CompiledName("vertical")>] Vertical of U2<bool,string>
        | [<CompiledName("horizontal")>] Horizontal of string
        | [<CompiledName("navbar")>] Navbar of bool
        | [<CompiledName("tag")>] Tag of string

    let nav (props: NavProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Nav" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems