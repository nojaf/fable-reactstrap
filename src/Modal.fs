namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module Modal =

    type ModalProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("isOpen")>] IsOpen of bool
        | [<CompiledName("autoFocus")>] AutoFocus of bool
        | [<CompiledName("centered")>] Centered of bool
        | [<CompiledName("size")>] Size of Common.Size
        | [<CompiledName("toggle")>] Toggle of (unit -> unit)
        | [<CompiledName("role")>] Role of string
        | [<CompiledName("labelledBy")>] LabelledBy of string
        | [<CompiledName("keyboard")>] Keyboard of bool
        | [<CompiledName("backdrop")>] Backdrop of U2<bool,string>
        | [<CompiledName("scrollable")>] Scrollable of bool
        | [<CompiledName("onEnter")>] OnEnter of (unit -> unit)
        | [<CompiledName("onExit")>] OnExit of (unit -> unit)
        | [<CompiledName("onOpened")>] OnOpened of (unit -> unit)
        | [<CompiledName("onClosed")>] OnClosed of (unit -> unit)
        | [<CompiledName("wrapClassName")>] WrapClassName of string
        | [<CompiledName("modalClassName")>] ModalClassName of string
        | [<CompiledName("backdropClassName")>] BackdropClassName of string
        | [<CompiledName("contentClassName")>] ContentClassName of string
        | [<CompiledName("fade")>] Fade of bool
        | [<CompiledName("cssModule")>] CssModule of CSSModule
        | [<CompiledName("zIndex")>] ZIndex of U2<int,string>
        | [<CompiledName("backdropTransition")>] BackdropTransition of Fade.FadeProps seq
        | [<CompiledName("modalTransition")>] ModalTransition of Fade.FadeProps seq
        | [<CompiledName("innerRef")>] InnerRef of (Element -> unit)
        | [<CompiledName("unmountOnClose")>] UnmountOnClose of bool

    let modal (props: ModalProps seq) (elems: ReactElement seq) : ReactElement =
        let modalProps =
            if Seq.isEmpty props then
                createObj []
            else
                props
                |> Seq.map (fun prop ->
                    match prop with
                    | BackdropTransition fade ->
                        createObj [ "backdropTransition" ==> keyValueList CaseRules.LowerFirst fade]
                    | ModalTransition fade ->
                        createObj [ "modalTransition" ==> keyValueList CaseRules.LowerFirst fade]
                    | prop ->
                        keyValueList CaseRules.LowerFirst (Seq.singleton prop)
                )
                |> Seq.reduce (fun a b -> Fable.Core.JS.Object.assign(a,b))
        
        ofImport "Modal" "reactstrap" modalProps elems