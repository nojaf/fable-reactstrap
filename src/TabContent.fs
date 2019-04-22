namespace ReactStrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open ReactStrap

[<RequireQualifiedAccess>]
module TabContent =

    type TabContentProps =
        | [<CompiledName("className")>] ClassName of string
        | [<CompiledName("tag")>] Tag of string
        | [<CompiledName("activeTab")>] ActiveTab of U2<string,int>
        | [<CompiledName("cssModule")>] CssModule of CSSModule

    let tabContent (props: TabContentProps seq) (elems: ReactElement seq) : ReactElement =
        ofImport "TabContent" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems