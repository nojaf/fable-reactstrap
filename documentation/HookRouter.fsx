#load "../.paket/load/netstandard2.0/main.group.fsx"

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open System.Text.RegularExpressions

type InterceptedPath = string option

[<RequireQualifiedAccess>]
type AProps =
    | Href of string
    | ClassName of string

let inline A (props: AProps list) (elems: ReactElement seq): ReactElement =
    ofImport "A" "hookrouter" (keyValueList CaseRules.LowerFirst props) elems

let AType: ReactElementType = import "A" "hookrouter"

let setLinkProps: AProps -> AProps = import "setLinkProps" "hookrouter"
let confirmNavigation: unit -> unit = import "confirmNavigation" "hookrouter"
let resetPath: unit -> unit = import "resetPath" "hookrouter"
let stopInterception: unit -> unit = import "stopInterception" "hookrouter"

let useControlledInterceptor: unit -> (InterceptedPath * obj * obj * obj) =
    import "useControlledInterceptor" "hookrouter"

let interceptRoute: string * string -> ResizeArray<string> = import "interceptRoute" "hookrouter"
let get: float -> obj option = import "get" "hookrouter"
let remove: float -> unit = import "remove" "hookrouter"
// let useInterceptor: handlerFn: (ResizeArray<obj option> -> obj option) -> (unit -> obj) = import "useInterceptor" "hookrouter"
let setobj: obj * bool -> unit = import "setobj" "hookrouter"
let getobj: unit -> obj = import "getobj" "hookrouter"

let queryStringToObject: string -> obj =
    import "queryStringToObject" "hookrouter"

let objectToQueryString: obj -> string =
    import "objectToQueryString" "hookrouter"

let useobj: unit -> (obj * obj) = import "useobj" "hookrouter"

let useRedirect (fromURL: string) (toURL: string) (queryParams: obj option) (replace: bool option): unit =
    import "useRedirect" "hookrouter"

let setBasepath: string -> unit = import "setBasepath" "hookrouter"
let getBasepath: unit -> string = import "getBasepath" "hookrouter"
let resolvePath: string -> string = import "resolvePath" "hookrouter"
let prepareRoute: string -> (Regex * ResizeArray<string>) = import "prepareRoute" "hookrouter"
let navigate: string * bool * obj * bool -> unit = import "navigate" "hookrouter"
let setPath: string -> unit = import "setPath" "hookrouter"
let getPath: unit -> string = import "getPath" "hookrouter"
let usePath: unit -> string = import "usePath" "hookrouter"
let updatePathHooks: unit -> unit = import "updatePathHooks" "hookrouter"
let getWorkingPath: string -> string = import "getWorkingPath" "hookrouter"
let useRoutes: obj -> ReactElement option = import "useRoutes" "hookrouter"
let useTitle: string -> unit = import "useTitle" "hookrouter"
let getTitle: unit -> string = import "getTitle" "hookrouter"
