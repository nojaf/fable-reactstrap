namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Tag =

    type TagProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("pill")>] Pill of bool

    let tag (props: TagProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Tag" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems