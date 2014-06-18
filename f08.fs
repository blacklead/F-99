let rec compress<'a> l =
  match l with
    | [] -> []
    | x::y::xs when x = y -> compress(y::xs)
    | x::xs -> x::compress xs
;;

compress ['a';'a';'a';'a';'b';'c';'c';'a';'a';'d';'e';'e';'e';'e'];;
