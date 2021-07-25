﻿namespace Avalonia.FuncUI.ControlCatalog

[<AutoOpen>]
module AvaloniaExtensions =
    open Avalonia.Markup.Xaml.Styling
    open System
    open Avalonia.Styling

    type Styles with
        member this.Load (source: string) = 
            let style = StyleInclude(baseUri = null)
            style.Source <- Uri(source)
            this.Add(style)
