module DosCalculator.Core.SRTP

let inline (^) f x = f(x)

let inline (..) x y =
    seq { x .. y } |> Seq.toArray