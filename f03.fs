let rec nth n l = 
  match (n, l) with
   | (n, []) -> failwith "no element"
   | (0, x::xs) -> x
   | (n, x::xs) -> nth (n-1) xs
;;

nth 2 [1;1;2;3;5;8];;
