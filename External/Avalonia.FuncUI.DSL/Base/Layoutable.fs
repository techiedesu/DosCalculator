namespace Avalonia.FuncUI.DSL

[<AutoOpen>]
module Layoutable =  
    open Avalonia
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    open Avalonia.Layout
              
    type Layoutable with
        static member width<'t when 't :> Layoutable>(value: double) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<double>(Layoutable.WidthProperty, value, ValueNone)
            
        static member height<'t when 't :> Layoutable>(value: double) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<double>(Layoutable.HeightProperty, value, ValueNone)
            
        static member minWidth<'t when 't :> Layoutable>(value: double) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<double>(Layoutable.MinWidthProperty, value, ValueNone)
            
        static member minHeight<'t when 't :> Layoutable>(value: double) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<double>(Layoutable.MinHeightProperty, value, ValueNone)
      
        static member maxWidth<'t when 't :> Layoutable>(value: double) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<double>(Layoutable.MaxWidthProperty, value, ValueNone)
            
        static member maxHeight<'t when 't :> Layoutable>(value: double) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<double>(Layoutable.MaxHeightProperty, value, ValueNone)
            
        static member margin<'t when 't :> Layoutable>(margin: Thickness) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<Thickness>(Layoutable.MarginProperty, margin, ValueNone)
            
        static member margin<'t when 't :> Layoutable>(margin: float) : IAttr<'t> =
            Thickness(margin) |> Layoutable.margin
            
        static member margin<'t when 't :> Layoutable>(horizontal: float, vertical: float) : IAttr<'t> =
            Thickness(horizontal, vertical) |> Layoutable.margin
            
        static member margin<'t when 't :> Layoutable>(left: float, top: float, right: float, bottom: float) : IAttr<'t> =
            Thickness(left, top, right, bottom) |> Layoutable.margin
    
        static member horizontalAlignment<'t when 't :> Layoutable>(value: HorizontalAlignment) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<HorizontalAlignment>(Layoutable.HorizontalAlignmentProperty, value, ValueNone)
   
        static member verticalAlignment<'t when 't :> Layoutable>(value: VerticalAlignment) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<VerticalAlignment>(Layoutable.VerticalAlignmentProperty, value, ValueNone)
           
        static member useLayoutRounding<'t when 't :> Layoutable>(value: bool) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<bool>(Layoutable.UseLayoutRoundingProperty, value, ValueNone)