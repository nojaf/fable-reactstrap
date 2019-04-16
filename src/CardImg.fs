namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardImg =
    
    type CardImgProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("top")>] Top of bool
        | [<CompiledName("bottom")>] Bottom of bool
        | [<CompiledName("src")>] Src of string
        | [<CompiledName("alt")>] Alt of string
        
    let cardImg (props: CardImgProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardImg" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems




