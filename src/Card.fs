namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Card =
    
    type CardProps =
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("inverse")>] Inverse of bool
        | [<CompiledName("outline")>] Outline of bool
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("body")>] Body of bool
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("style")>] Style of CSSProp list
        
    let card (props: CardProps seq) (elems: ReactElement seq) : ReactElement =
        let cardProps =
            if Seq.isEmpty props then
                createObj []
            else
                props
                |> Seq.map (fun prop ->
                    match prop with
                    | Style style ->
                        createObj [ "style" ==> keyValueList CaseRules.LowerFirst style]
                    | prop ->
                        keyValueList CaseRules.LowerFirst (Seq.singleton prop)
                )
                |> Seq.reduce (fun a b -> Fable.Core.JS.Object.assign(a,b))

        ofImport "Card" "reactstrap" cardProps elems

