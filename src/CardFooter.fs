namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardFooter =
    
    type CardFooterProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        
    let cardFooter (props: CardFooterProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardFooter" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems

