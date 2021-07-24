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
            
    member this.getNode x y =
        this.nodes |> Array.find ^ fun node -> node.x = x && node.y = y
           
           
module Matrix =
    let create x y =
        { x = x
          y = y
          nodes = Array.zeroCreate ^ x * y }
        
    let map (predicate: int -> int -> Expression -> Expression) (matrix: Matrix) : Matrix =
        let nodes = matrix.nodes
                    |> Array.map ^ fun node ->
                        { x = node.x
                          y = node.y
                          expression = predicate node.x node.y node.expression }
        { x = matrix.x
          y = matrix.y
          nodes = nodes }

module SRTP =
    let act (matrix1: Matrix) (matrix2: Matrix) (action: Expression -> Expression -> Expression) =
        let areMatricesSquare = matrix1.isSquare() && matrix2.isSquare()
        let areDimensionsEquals = matrix1.x = matrix2.x
        let matrixSize = matrix1.x
        
        if  areMatricesSquare && areDimensionsEquals then
            let matrix = Matrix.create matrixSize matrixSize
            let nodes = matrix.nodes
                            |> Array.map ^ fun node ->
                                let x = node.x
                                let y = node.y
                                let expression = action (matrix1.getNode x y).expression (matrix2.getNode x y).expression
                                
                                { x = x
                                  y = y
                                  expression = expression }
                
            Some { matrix with nodes = nodes }
        else
            None
    
    let inline (+) (matrix1: Matrix) (matrix2: Matrix) =
        act matrix1 matrix2 (fun x y -> x + y)
            
    let inline (*) (matrix1: Matrix) (matrix2: Matrix) =
        act matrix1 matrix2 (fun x y -> x * y)

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