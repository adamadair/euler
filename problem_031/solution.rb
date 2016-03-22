coins = [ 1, 2, 5, 10, 20, 50, 100, 200 ] 
amount = 200
ways = Array.new(amount+1,0)
ways [0] = 1;
for i in (0..7) do
  for j in (coins[i]..amount) do
    ways[j] = ways[j] + ways[j-coins[i]] 
  end # j
end # i
puts ways[amount]