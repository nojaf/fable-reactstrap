namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Badge =
    
    type BadgeProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("pill")>] Pill
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("cssModule")>] CSSModule of Common.CSSModule
        | [<CompiledName("transition")>] Transition of TransitionProps
        | [<CompiledName("href")>] Href of string

    let badge (props: BadgeProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "Badge" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems