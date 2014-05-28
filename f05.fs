let rec reverse = function
 | [] -> []
 | x::xs -> (reverse xs) @ [x]
;;

reverse [1;1;2;3;5;8];;
