type 'a NestedList = List of 'a NestedList list | Elem of 'a ;;

let rec flatten = function
 | Elem x -> [x]
 | List l -> List.collect (fun x -> flatten x) l
;;

flatten (List [List [Elem 1; Elem 1]; Elem 2; List [Elem 3; List [Elem 5; Elem 8]]]) ;;
