namespace DosCalculator.Avalonia.Components

open Avalonia.FuncUI.DSL
open Avalonia.Controls
open Avalonia.Layout

open DosCalculator.Core.Extensions.SRTP

module MatrixSize =
    type State = { size: int }
    let init = { size = 5 }
    
    type Msg =
    | Increment
    | Decrement
    | SetSize of int
    
    let update msg state =
        match msg with
        | Increment ->
            if state.size = 10 then
                state
            else
                { state with size = state.size + 1 }
        | Decrement ->
            if state.size = 1 then
                state
            else
                { state with size = state.size - 1 }
        | SetSize x ->
            { state with size = x }

    let view (state: State) dispatch =
        DockPanel.create [
            DockPanel.children [
                    Button.create [
                        Button.dock Dock.Bottom
                        Button.onClick ^ fun _ -> dispatch Increment
                        Button.content "+"
                        Button.horizontalAlignment HorizontalAlignment.Stretch ]
                    
                    Button.create [
                        Button.dock Dock.Bottom
                        Button.onClick ^ fun _ -> dispatch Decrement
                        Button.content "-"
                        Button.horizontalAlignment HorizontalAlignment.Stretch ]
                    
                    TextBlock.create [
                    TextBlock.dock Dock.Top
                    TextBlock.fontSize 48.0
                    TextBlock.verticalAlignment VerticalAlignment.Center
                    TextBlock.horizontalAlignment HorizontalAlignment.Center
                    TextBlock.text ^ string state.size ] ] ]