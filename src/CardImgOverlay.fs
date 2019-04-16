namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardImgOverlay =
    
    type CardImgOverlayProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        
    let cardImgOverlay (props: CardImgOverlayProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardImgOverlay" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems



