namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Toast =

    type ToastProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("color")>] Color of Common.Color
        | [<CompiledName("isOpen")>] IsOpen of bool
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("transition")>] Transition of Fade.FadeProps seq

    let toast (props: ToastProps seq) (elems: ReactElement seq) : ReactElement =
        let toastProps =
            if Seq.isEmpty props then
                createObj []
            else
                props
                |> Seq.map (fun prop ->
                    match prop with
                    | Transition fade ->
                        createObj [ "transition" ==> keyValueList CaseRules.LowerFirst fade]
                    | prop ->
                        keyValueList CaseRules.LowerFirst (Seq.singleton prop)
                )
                |> Seq.reduce (fun a b -> Fable.Core.JS.Object.assign(a,b))
        
        ofImport "Modal" "reactstrap" toastProps elems