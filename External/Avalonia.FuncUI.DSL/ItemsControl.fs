namespace Avalonia.FuncUI.DSL

[<AutoOpen>]
module ItemsControl =
    open Avalonia.Controls.Templates
    open System.Collections
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<ItemsControl> list): IView<ItemsControl> =
        ViewBuilder.Create<ItemsControl>(attrs)
     
    type ItemsControl with
  
        static member viewItems<'t when 't :> ItemsControl>(views: IView list) : IAttr<'t> =
            AttrBuilder<'t>.CreateContentMultiple(ItemsControl.ItemsProperty, views)
            
        static member dataItems<'t when 't :> ItemsControl>(data: IEnumerable) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<IEnumerable>(ItemsControl.ItemsProperty, data, ValueNone)
            
        static member itemsPanel<'t when 't :> ItemsControl>(value: ITemplate<IPanel>) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<ITemplate<IPanel>>(ItemsControl.ItemsPanelProperty, value, ValueNone)
            
        static member itemTemplate<'t when 't :> ItemsControl>(value: IDataTemplate) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<IDataTemplate>(ItemsControl.ItemTemplateProperty, value, ValueNone)