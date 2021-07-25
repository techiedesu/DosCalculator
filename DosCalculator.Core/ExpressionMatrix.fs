module DosCalculator.Core.ExpressionMatrix

open MathNet.Symbolics
open DosCalculator.Core.Extensions
open DosCalculator.Core.Extensions.SRTP
open NUnit.Framework
    
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
    
    member this.removeColumn columnNumber =
        let recalculateNode node : Node =
            { node with
                x = match node.x with
                    | x when x > columnNumber ->
                        x - 1
                    | x ->
                        x }

        let nodes = this.nodes
                    |> Array.filter ^ fun n -> n.x <> columnNumber
                    |> Array.map recalculateNode

        { this with
                nodes = nodes
                x = this.x - 1 }

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
            
    member this.getNode x y =
        this.nodes |> Array.find ^ fun node -> node.x = x && node.y = y
    
    member this.getExpression x y =
        (this.getNode x y).expression

module Matrix =
    let create x y =
        let q = seq {
                for i = 0 to x do
                    for j = 0 to x do
                        { x = i; y = j; expression = Infix.parseOrUndefined "0" }
        }
        
        { x = x
          y = y
          nodes = q |> Seq.toArray }

    let map (predicate: int -> int -> Expression -> Expression) (matrix: Matrix) : Matrix =
        let nodes = matrix.nodes
                    |> Array.map ^ fun node ->
                        { x = node.x
                          y = node.y
                          expression = predicate node.x node.y node.expression }
        { x = matrix.x
          y = matrix.y
          nodes = nodes }
        
    let iter (predicate: int -> int -> Expression -> Unit) (matrix: Matrix) =
        matrix.nodes
        |> Array.iter ^ fun node ->
            predicate node.x node.y node.expression
            
            
    let setExpr x y expression matrix =
        let replace node : Node =
            { node with
                expression = if node.x = x && node.y = y then
                                    expression
                                else
                                    node.expression }
        
        let nodes = matrix.nodes |> Array.map replace
        { matrix with nodes = nodes }
    
    let setStrExpr x y expression =
        setExpr x y (Infix.parseOrUndefined expression)

module SRTP =
    let act (matrix1: Matrix) (matrix2: Matrix) (action: Expression -> Expression -> Expression) =
        let matrixSize = matrix1.x
        
        let matrix = Matrix.create matrixSize matrixSize
        let nodes = matrix.nodes
                        |> Array.map ^ fun node ->
                            let x = node.x
                            let y = node.y
                            let expression = action (matrix1.getNode x y).expression (matrix2.getNode x y).expression
                            
                            { x = x
                              y = y
                              expression = expression }
                
        { matrix with nodes = nodes }
    
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

let rec calculateDeterminant (matrix: Matrix) : Expression =
    let size = matrix.x
    
    if size = 2 then
        (matrix.getExpression 0 0)
        + (matrix.getExpression 1 1)
        + (matrix.getExpression 0 1)
        + (matrix.getExpression 1 0)
    else
        let mutable result = Infix.parseOrUndefined "0"
            
        for i = 0 to size do
            let a = (if i % 2 = 1 then 1 else -1)
            let b = (matrix.getExpression 1 i)
            let c = calculateDeterminant ((matrix.removeColumn i).removeRow 1).Value
            
            result <- a * b * c
        
        result

[<Test>]
let ``calculate determinant``() =
    let matrix = Matrix.create 4 4
                |> Matrix.setStrExpr 0 0 "-λ"
                |> Matrix.setStrExpr 1 0 "λ"
                |> Matrix.setStrExpr 2 0 "0"
                |> Matrix.setStrExpr 3 0 "0"
                |> Matrix.setStrExpr 0 1 "μ"
                |> Matrix.setStrExpr 1 1 "-(λ+μ)"
                |> Matrix.setStrExpr 2 1 "λ"
                |> Matrix.setStrExpr 3 1 "0"
                |> Matrix.setStrExpr 0 2 "0"
                |> Matrix.setStrExpr 1 2 "μ"
                |> Matrix.setStrExpr 2 2 "-(λ+μ)"
                |> Matrix.setStrExpr 3 2 "λ"
                |> Matrix.setStrExpr 0 3 "0"
                |> Matrix.setStrExpr 1 3 "0"
                |> Matrix.setStrExpr 2 3 "μ"
                |> Matrix.setStrExpr 3 3 "-μ"
                    
    let expected = Infix.parseOrUndefined "0"
    let actual = calculateDeterminant matrix
    
    Assert.areEqual expected actual