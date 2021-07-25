namespace Avalonia.FuncUI.VirtualDom

open System
open System.Threading

open Avalonia.FuncUI.Types

module internal rec Delta =
    
    type AttrDelta =
        | Property of PropertyDelta
        | Content of ContentDelta
        | Subscription of SubscriptionDelta   

        static member From (attr: IAttr) : AttrDelta =
            match attr with
            | Property' property -> Property (PropertyDelta.From property)
            | Content' content -> Content (ContentDelta.From content)
            | Subscription' subscription -> Subscription (SubscriptionDelta.From subscription)
            | _ -> raise (Exception "unknown IAttr type. (not a Property, Content ore Subscription attribute)")
                
           
    [<CustomEquality; NoComparison>]
    type PropertyDelta =
        { Accessor: Accessor
          Value: obj option
          DefaultValueFactory: (unit -> obj) voption }

        static member From (property: Property) : PropertyDelta =
            { Accessor = property.Accessor
              Value = Some property.Value
              DefaultValueFactory = property.DefaultValueFactory }
            
        override this.Equals (other: obj) : bool =
            match other with
            | :? PropertyDelta as other -> 
                this.Accessor = other.Accessor &&
                this.Value = other.Value
            | _ -> false
                
        override this.GetHashCode () =
            (this.Accessor, this.Value).GetHashCode()

                
    [<CustomEquality; NoComparison>]
    type SubscriptionDelta =
        { Name: string
          Subscribe: Avalonia.Controls.IControl * Delegate -> CancellationTokenSource
          Func: Delegate option }

        override this.Equals (other: obj) : bool =
            match other with
            | :? Subscription as other -> 
                this.Name = other.Name
            | _ -> false
                
        override this.GetHashCode () =
            this.Name.GetHashCode()
            
        static member From (subscription: Subscription) : SubscriptionDelta =
            { Name = subscription.Name;
              Subscribe = subscription.Subscribe;
              Func = Some subscription.Func }
            
        member this.UniqueName = this.Name
    
    type  ContentDelta =
        { Accessor: Accessor
          Content: ViewContentDelta }

        static member From (content: Content) : ContentDelta =
            { Accessor = content.Accessor;
              Content = ViewContentDelta.From content.Content }
        
    type ViewContentDelta =
        | Single of ViewDelta option
        | Multiple of ViewDelta list

        static member From (viewContent: ViewContent) : ViewContentDelta =
            match viewContent with
            | ViewContent.Single single ->
                match single with
                | Some view ->
                    (ViewDelta.From view)
                    |> Some
                    |> ViewContentDelta.Single
                | None ->
                    None
                    |> ViewContentDelta.Single
                    
            | ViewContent.Multiple multiple ->
                multiple
                |> List.map (fun view -> ViewDelta.From view)
                |> ViewContentDelta.Multiple

    type ViewDelta =
        { ViewType: Type
          Attrs: AttrDelta list }

        static member From (view: IView) : ViewDelta =
            { ViewType = view.ViewType
              Attrs = view.Attrs |> List.map AttrDelta.From }