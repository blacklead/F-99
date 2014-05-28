let rec length = function
 | [] -> 0
 | x::xs -> 1 + length xs
;;

length [1;1;2;3;5;8];;
