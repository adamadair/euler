def cal_chain(x)
  chain = 1;
  n = x
  while (n>1) do
    if n % 2 == 0
      n = n/2
      chain += 1
    else 
      n = (3*n)+1
      chain += 1
    end
  end
  chain
end

curr_top_num = 0
curr_chain_len = 0

for i in 1..999_999
  len = cal_chain(i)
  if len > curr_chain_len
    curr_chain_len = len
    curr_top_num = i
  end
  puts "#{i} : #{len}"
end
puts "**********************"
puts "#{curr_top_num} : #{curr_chain_len}"
