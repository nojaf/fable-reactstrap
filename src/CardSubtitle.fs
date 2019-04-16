namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardSubtitle =
    
    type CardSubtitleProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        
    let cardSubtitle (props: CardSubtitleProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardSubtitle" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems




