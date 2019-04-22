namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module TabPane =

    type TabPaneProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("tabId")>] TabId of U2<string,int>
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let tabPane (props: TabPaneProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "TabPane" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems