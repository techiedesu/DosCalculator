module DosCalculator.Core.Extensions

open NUnit.Framework

type Assert with
    static member areEqual expected actual =
        Assert.AreEqual (expected, actual)
        
module SRTP =
    let inline (^) f x = f(x)