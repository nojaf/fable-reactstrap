namespace Reactstrap

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Reactstrap

[<RequireQualifiedAccess>]
module Uncontrolled =

    type UncontrolledProps = Custom of IHTMLProp list

    let uncontrolled (props: UncontrolledProps seq) (elems: ReactElement seq): ReactElement =
        ofImport "Uncontrolled" "reactstrap" (keyValueList CaseRules.LowerFirst props) elems
