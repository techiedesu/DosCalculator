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
    
    member this.removeColumnRow number =
        let recalculateNodeX node : Node =
            { node with
                x = match node.x with
                    | x when x > number ->
                        x - 1
                    | x ->
                        x }
            
        let recalculateNodeY node : Node =
            { node with
                y = match node.y with
                    | y when y > number ->
                        y - 1
                    | y ->
                        y }
        
        if this.x > number && this.y > number then
            let nodes = this.nodes
                        |> Array.filter ^ fun n -> n.x <> number
                        |> Array.map recalculateNodeX
                        |> Array.map recalculateNodeY
            
            Some { this with
                    nodes = nodes
                    x = this.x - 1 }
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