namespace Avalonia.FuncUI.DSL

[<AutoOpen>]
module RenderOptions =  
    open Avalonia.Controls
    open Avalonia.Media
    open Avalonia.Visuals.Media.Imaging
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    type Control with
        static member bitmapInterpolationMode<'t when 't :> Control>(mode: BitmapInterpolationMode) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<BitmapInterpolationMode>(RenderOptions.BitmapInterpolationModeProperty, mode, ValueNone)
    
    type RenderOptions with
        end