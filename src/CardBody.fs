namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<RequireQualifiedAccess>]
module CardBody =
    
    type CardBodyProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        
    let cardBody (props: CardBodyProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardBody" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems

