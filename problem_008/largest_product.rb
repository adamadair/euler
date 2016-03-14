# calculate product of len number of integers
# in the integer array ary, starting at index and 
# working backwards. I know this is a a strange way
# of doing it, but it works for this solution.
def calc_product(ary, index, len)
  prod = 1
  print "1"
  ((index-(len-1))..index).each{|d| 
    prod = prod * ary[d]
    print " x #{ary[d]}" 
  }
  puts " = #{prod}"
  prod
end

# The number string straight from the problem text
number_string = '73167176531330624919225119674426574742355349194934'\
'96983520312774506326239578318016984801869478851843'\
'85861560789112949495459501737958331952853208805511'\
'12540698747158523863050715693290963295227443043557'\
'66896648950445244523161731856403098711121722383113'\
'62229893423380308135336276614282806444486645238749'\
'30358907296290491560440772390713810515859307960866'\
'70172427121883998797908792274921901699720888093776'\
'65727333001053367881220235421809751254540594752243'\
'52584907711670556013604839586446706324415722155397'\
'53697817977846174064955149290862569321978468622482'\
'83972241375657056057490261407972968652414535100474'\
'82166370484403199890008895243450658541227588666881'\
'16427171479924442928230863465674813919123162824586'\
'17866458359124566529476545682848912883142607690042'\
'24219022671055626321111109370544217506941658960408'\
'07198403850962455444362981230987879927244284909188'\
'84580156166097919133875499200524063689912560717606'\
'05886116467109405077541002256983155200055935729725'\
'71636269561882670428252483600823257530420752963450'

# convert the string into and array of digits. Convert
# each text digit to integer value just once during the
# running of the program.
d_array = Array.new
number_string.each_char {|d| d_array << d.to_i}

# Since the product of any set of digits that contains zero is zero the 
# strategy is to only calculate products for sets that are all non-zero.

non_zero_count = 0
index = 0
min_len = 13        # minimum length set by the problem
top_product = 0

for d in d_array do
  if d == 0
    non_zero_count = 0
  else
    non_zero_count += 1
  end
  if(index >= (min_len - 1) && non_zero_count >= min_len)
    prod = calc_product(d_array, index, min_len)
    top_product = prod if(prod>top_product)
  end
  index += 1
end

puts "largest product: #{top_product}"


