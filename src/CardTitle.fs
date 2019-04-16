namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardTitle =
    
    type CardTitleProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        
    let cardTitle (props: CardTitleProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardTitle" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems