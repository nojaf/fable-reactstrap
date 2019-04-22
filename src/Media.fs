namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Media =

    type MediaProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("body")>] Body of bool
        | [<CompiledName("bottom")>] Bottom of bool
        | [<CompiledName("heading")>] Heading of bool
        | [<CompiledName("left")>] Left of bool
        | [<CompiledName("list")>] List of bool
        | [<CompiledName("middle")>] Middle of bool
        | [<CompiledName("object")>] Object of bool
        | [<CompiledName("right")>] Right of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("top")>] Top of bool

    let media (props: MediaProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Media" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems