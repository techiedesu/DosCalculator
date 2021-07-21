module DosCalculator.Core.ExpressionMatrix

open MathNet.Symbolics
open DosCalculator.Core.SRTP
    
type Node = {
    x: int
    y: int
    expression: Expression
}

type Matrix = {
    x: int
    y: int
    nodes: Node[]
}

type Matrix with
    member this.isSquare() =
        this.x = this.y
    
    // TODO: Merge removeColumn and removeRow to one function
    member this.removeColumn columnNumber =
        let recalculateNode node : Node =
            { node with
                x = match node.x with
                    | x when x > columnNumber ->
                        x - 1
                    | x ->
                        x }
        
        if this.x > columnNumber then
            let nodes = this.nodes
                        |> Array.filter ^ fun n -> n.x <> columnNumber
                        |> Array.map recalculateNode
            
            Some { this with
                    nodes = nodes
                    x = this.x - 1 }
        else
            None

        member this.removeRow rowNumber =
        let recalculateNode node : Node =
            { node with
                y = match node.y with
                    | y when y > rowNumber ->
                        y - 1
                    | y ->
                        y }
        
        if this.y > rowNumber then
            let nodes = this.nodes
                        |> Array.filter ^ fun n -> n.y <> rowNumber
                        |> Array.map recalculateNode
            
            Some { this with
                    nodes = nodes
                    y = this.y - 1 }
        else
            None

// TODO: Tests.
let setExpression (matrix: Matrix) x y expression =
    if matrix.x > x && matrix.y > y then
        let nodes
            = matrix.nodes
                |> Array.map ^
                       fun n ->
                            match n with
                            | n when n.x = x && n.y = y ->
                                { x = x; y = y; expression = expression }
                            | n -> n
        Some { matrix with nodes = nodes }
    else
        None
        
let createMatrix x y =
    { x = x; y = y; nodes = Array.zeroCreate ^ x * y }
    
let calculateDeterminant (matrix: Matrix) : Expression =
    failwith "TODO"