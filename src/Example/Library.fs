namespace Example

[<Myriad.Core.MyriadGenerator("fields")>]
type Test1 = { one: int; two: string; three: float; four: float32 }

[<Myriad.Core.MyriadGenerator("fields")>]
type Test2 = { one: Test1; two: string }
