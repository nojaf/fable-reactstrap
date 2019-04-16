namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<RequireQualifiedAccess>]
module CardLink =
    
    type CardLinkProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("innerRef")>] InnerRef of (Element -> unit)
        
    let cardLink (props: CardLinkProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "CardLink" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems





