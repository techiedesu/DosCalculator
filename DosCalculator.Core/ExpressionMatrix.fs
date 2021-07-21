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