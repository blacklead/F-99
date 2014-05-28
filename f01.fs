let rec last = function
 | [] -> failwith "no element"
 | x::[] -> x
 | x::xs -> last xs
;;

last [1;1;2;3;5;8];;
