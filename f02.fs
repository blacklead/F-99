let rec penultimate = function
 | [] -> failwith "no element"
 | x::[xs] -> x
 | x::xs -> penultimate xs
;;

penultimate [1;1;2;3;5;8];;
