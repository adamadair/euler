require "../lib/ruby/is_prime"
largest = 0
(2..99999).select{|n|
  num=""
  i = 1
  while num.length<9 do
    num = num + (n*i).to_s
    i += 1
  end
  
  if num.length==9
    int = num.to_i
    largest = int if int.pandigital?(9)&&int>largest
  end
}
puts largest
