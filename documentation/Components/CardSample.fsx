#load "../../.paket/load/netstandard2.0/main.group.fsx"
#load "../../src/Common.fs"
#load "../../src/Card.fs"
#load "../../src/CardImg.fs"
#load "../../src/CardBody.fs"
#load "../../src/CardHeader.fs"
#load "../../src/CardTitle.fs"
#load "../../src/CardSubtitle.fs"
#load "../../src/CardText.fs"
#load "../../src/CardGroup.fs"
#load "../../src/CardDeck.fs"
#load "../../src/CardColumns.fs"
#load "../../src/CardFooter.fs"
#load "../../src/Button.fs"

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Reactstrap

let private cardSample =
    FunctionComponent.Of<obj>
        ((fun _ ->
            fragment []
                [ Card.card [ Card.Custom([ ClassName "w-50" ]) ]
                      [ CardImg.cardImg
                          [ CardImg.Top true
                            CardImg.Custom([ Src "http://lorempixel.com/400/200/" ]) ] []
                        CardBody.cardBody []
                            [ CardTitle.cardTitle [ CardTitle.Tag !^"h5" ] [ str "Card title" ]
                              CardSubtitle.cardSubtitle
                                  [ CardSubtitle.Tag !^"h6"
                                    CardSubtitle.Custom([ ClassName "mb-1" ]) ] [ str "Card subtitle" ]
                              CardText.cardText []
                                  [ str
                                      "Some quick example text to build on the card title and make up the bulk of the card's content." ]
                              Button.button [ Button.Color Primary ] [ str "Button" ] ] ]
                  h5 [ ClassName "mt-2" ] [ str "Header and Footer" ]
                  Card.card []
                      [ CardHeader.cardHeader [] [ str "Header" ]
                        CardBody.cardBody []
                            [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                              CardText.cardText []
                                  [ str "With supporting text below as a natural lead-in to additional content." ]
                              Button.button [] [ str "Go somewhere" ] ]
                        CardFooter.cardFooter [] [ str "Footer" ] ]
                  h5 [ ClassName "mt-2" ] [ str "Background variants" ]
                  Card.card
                      [ Card.Body true
                        Card.Inverse true
                        Card.Custom
                            ([ ClassName "w-50"
                               Style
                                   [ BackgroundColor "#333"
                                     BorderColor "#333" ] ]) ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  Card.card
                      [ Card.Body true
                        Card.Inverse true
                        Card.Color Primary
                        Card.Custom([ ClassName "w-50" ]) ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  Card.card
                      [ Card.Body true
                        Card.Inverse true
                        Card.Color Success
                        Card.Custom([ ClassName "w-50" ]) ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  Card.card
                      [ Card.Body true
                        Card.Inverse true
                        Card.Color Info
                        Card.Custom([ ClassName "w-50" ]) ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  Card.card
                      [ Card.Body true
                        Card.Inverse true
                        Card.Color Warning
                        Card.Custom([ ClassName "w-50" ]) ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  Card.card
                      [ Card.Body true
                        Card.Inverse true
                        Card.Color Danger
                        Card.Custom([ ClassName "w-50" ]) ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  h5 [ ClassName "mt-2" ] [ str "Outline variants" ]
                  Card.card
                      [ Card.Body true
                        Card.Color Primary
                        Card.Custom([ ClassName "w-50" ])
                        Card.Outline true ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  Card.card
                      [ Card.Body true
                        Card.Color Success
                        Card.Custom([ ClassName "w-50" ])
                        Card.Outline true ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  Card.card
                      [ Card.Body true
                        Card.Color Info
                        Card.Custom([ ClassName "w-50" ])
                        Card.Outline true ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  Card.card
                      [ Card.Body true
                        Card.Color Warning
                        Card.Custom([ ClassName "w-50" ])
                        Card.Outline true ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  Card.card
                      [ Card.Body true
                        Card.Color Danger
                        Card.Custom([ ClassName "w-50" ])
                        Card.Outline true ]
                      [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                        CardText.cardText []
                            [ str "With supporting text below as a natural lead-in to additional content." ]
                        Button.button [] [ str "Button" ] ]
                  h5 [ ClassName "mt-2" ] [ str "Groups" ]
                  CardGroup.cardGroup []
                      [ Card.card []
                            [ CardImg.cardImg
                                [ CardImg.Top true
                                  CardImg.Custom
                                      ([ Src "http://lorempixel.com/400/200/"
                                         HTMLAttr.Width "100%" ]) ] []
                              CardBody.cardBody []
                                  [ CardTitle.cardTitle [] [ str "Card title" ]
                                    CardSubtitle.cardSubtitle [] [ str "Card subtitle" ]
                                    CardText.cardText []
                                        [ str
                                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer." ]
                                    Button.button [] [ str "Button" ] ] ]
                        Card.card []
                            [ CardImg.cardImg
                                [ CardImg.Top true
                                  CardImg.Custom
                                      ([ Src "http://lorempixel.com/400/200/"
                                         HTMLAttr.Width "100%" ]) ] []
                              CardBody.cardBody []
                                  [ CardTitle.cardTitle [] [ str "Card title" ]
                                    CardSubtitle.cardSubtitle [] [ str "Card subtitle" ]
                                    CardText.cardText []
                                        [ str
                                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer." ]
                                    Button.button [] [ str "Button" ] ] ]
                        Card.card []
                            [ CardImg.cardImg
                                [ CardImg.Top true
                                  CardImg.Custom
                                      ([ Src "http://lorempixel.com/400/200/"
                                         HTMLAttr.Width "100%" ]) ] []
                              CardBody.cardBody []
                                  [ CardTitle.cardTitle [] [ str "Card title" ]
                                    CardSubtitle.cardSubtitle [] [ str "Card subtitle" ]
                                    CardText.cardText []
                                        [ str
                                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer." ]
                                    Button.button [] [ str "Button" ] ] ] ]
                  h5 [ ClassName "mt-2" ] [ str "Decks" ]
                  CardDeck.cardDeck []
                      [ Card.card []
                            [ CardImg.cardImg
                                [ CardImg.Top true
                                  CardImg.Custom
                                      ([ Src "http://lorempixel.com/400/200/"
                                         HTMLAttr.Width "100%" ]) ] []
                              CardBody.cardBody []
                                  [ CardTitle.cardTitle [] [ str "Card title" ]
                                    CardSubtitle.cardSubtitle [] [ str "Card subtitle" ]
                                    CardText.cardText []
                                        [ str
                                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer." ]
                                    Button.button [] [ str "Button" ] ] ]
                        Card.card []
                            [ CardImg.cardImg
                                [ CardImg.Top true
                                  CardImg.Custom
                                      ([ Src "http://lorempixel.com/400/200/"
                                         HTMLAttr.Width "100%" ]) ] []
                              CardBody.cardBody []
                                  [ CardTitle.cardTitle [] [ str "Card title" ]
                                    CardSubtitle.cardSubtitle [] [ str "Card subtitle" ]
                                    CardText.cardText []
                                        [ str
                                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer." ]
                                    Button.button [] [ str "Button" ] ] ]
                        Card.card []
                            [ CardImg.cardImg
                                [ CardImg.Top true
                                  CardImg.Custom
                                      ([ Src "http://lorempixel.com/400/200/"
                                         HTMLAttr.Width "100%" ]) ] []
                              CardBody.cardBody []
                                  [ CardTitle.cardTitle [] [ str "Card title" ]
                                    CardSubtitle.cardSubtitle [] [ str "Card subtitle" ]
                                    CardText.cardText []
                                        [ str
                                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer." ]
                                    Button.button [] [ str "Button" ] ] ] ]
                  h5 [ ClassName "mt-2" ] [ str "Columns" ]
                  CardColumns.cardColumns []
                      [ Card.card []
                            [ CardImg.cardImg
                                [ CardImg.Top true
                                  CardImg.Custom
                                      ([ Src "http://lorempixel.com/400/200/"
                                         HTMLAttr.Width "100%" ]) ] []
                              CardBody.cardBody []
                                  [ CardTitle.cardTitle [] [ str "Card title" ]
                                    CardSubtitle.cardSubtitle [] [ str "Card subtitle" ]
                                    CardText.cardText []
                                        [ str
                                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer." ]
                                    Button.button [] [ str "Button" ] ] ]
                        Card.card []
                            [ CardImg.cardImg
                                [ CardImg.Top true
                                  CardImg.Custom
                                      ([ Src "http://lorempixel.com/400/200/"
                                         HTMLAttr.Width "100%" ]) ] [] ]
                        Card.card []
                            [ CardImg.cardImg
                                [ CardImg.Top true
                                  CardImg.Custom([ Src "http://lorempixel.com/400/200/" ]) ] []
                              CardBody.cardBody []
                                  [ CardTitle.cardTitle [] [ str "Card title" ]
                                    CardSubtitle.cardSubtitle [] [ str "Card subtitle" ]
                                    CardText.cardText []
                                        [ str
                                            "This card has supporting text below as a natural lead-in to additional content." ]
                                    Button.button [] [ str "Button" ] ] ]
                        Card.card
                            [ Card.Body true
                              Card.Inverse true
                              Card.Custom
                                  ([ Style
                                      [ BackgroundColor "#333"
                                        BorderColor "#333" ] ]) ]
                            [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                              CardText.cardText []
                                  [ str "With supporting text below as a natural lead-in to additional content." ]
                              Button.button [] [ str "Button" ] ]
                        Card.card []
                            [ CardImg.cardImg
                                [ CardImg.Top true
                                  CardImg.Custom
                                      ([ Src "http://lorempixel.com/400/200/"
                                         HTMLAttr.Width "100%" ]) ] []
                              CardBody.cardBody []
                                  [ CardTitle.cardTitle [] [ str "Card title" ]
                                    CardSubtitle.cardSubtitle [] [ str "Card subtitle" ]
                                    CardText.cardText []
                                        [ str
                                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer." ]
                                    Button.button [] [ str "Button" ] ] ]
                        Card.card
                            [ Card.Body true
                              Card.Inverse true
                              Card.Color Primary ]
                            [ CardTitle.cardTitle [] [ str "Special Title Treatment" ]
                              CardText.cardText []
                                  [ str
                                      "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer." ]
                              Button.button [] [ str "Button" ] ] ] ]), "CardSample")

exportDefault cardSample
