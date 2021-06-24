let list1 = [ 7; 9; 11 ]
let list2 = []
// Properties
printfn "list1.IsEmpty is %b" (list1.IsEmpty)
printfn "list1.IsEmpty is %b" (list2.IsEmpty) // liste boş mu
printfn "list1.Length is %d" (list1.Length) // uzunluğu
printfn "list1.Head is %d" (list1.Head) // ilk değer bakar
printfn "list1.Tail.Head is %d" (list1.Tail.Head) // tail.head 1 adım attı ve sayısında baktı(head)
printfn "list1.Tail.Tail.Head is %d" (list1.Tail.Tail.Head) // tail tail ile listede geziyoruz
printfn "list1.Item(1) is %d" (list1.Item(0)) //İndex numarasındaki sayı kaç