namespace ReactStrap

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Form =
    type FormProps = Custom of HTMLAttr list

    let form (props: FormProps seq) (elems: ReactElement seq): ReactElement =
        let props = keyValueList CaseRules.LowerFirst props
        ofImport "Form" "reactstrap" props elems
