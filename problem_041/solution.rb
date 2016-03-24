require "../lib/ruby/is_prime"
top = 0
# (11..987654321).select{|x| top = x if x.prime? && x.pandigital?(x.to_s.length)}
# puts top
class Array
  def deep_dup
    map {|x| x.deep_dup}
  end
end

class Object
  def deep_dup
    dup
  end
end

class Numeric
  # We need this because number.dup throws an exception
  # We also need the same definition for Symbol, TrueClass and FalseClass
  def deep_dup
    self
  end
end

def swap(sArray, k, l)
  tmp = sArray[k];
  sArray[k] = sArray[l];
	sArray[l] = tmp;
end # swap

def reverse(sArray, start, stop)
  if start < 0 || start >= sArray.length || stop < 0 || stop >= sArray.length
    return
  end
  while start < stop do
    swap(sArray, start, stop)
    start += 1
    stop -= 1
	end # while
end # reverse

def LexoPerm(digits)
  tmp_array = digits.deep_dup
  nums = []
  length = tmp_array.length
  k = 0
	while k >= 0 do
    # 1. Find the largest index `k` such that `a[k] < a[k + 1]`. 
    # If no such index exists, the permutation is the last permutation.
		k = tmp_array.length - 2; #point k to the last element in the array
		while (k >= 0 && tmp_array[k] >= tmp_array [k + 1]) do 
      k-=1 
    end
    
		return nums if (k < 0)
		  
    # 2. Find the largest index `l` greater than k such that `a[k] < a[l]`.
		l = length-1;
		while(tmp_array[l]<=tmp_array[k]) do 
      l -= 1
    end

		# 3. Swap the value of `a[k]` with that of `a[l]`.
		swap(tmp_array,k,l);

		# 4. Reverse the sequence from `a[k + 1]` up to and including the final element `a[n]`.
		reverse(tmp_array, k+1, length-1);
    #puts tmp_array.join
		nums << tmp_array.join.to_i
	end
	nums  
end
topPrime = 0;
num_array = ['1','2','3','4','5','6','7','8','9']
puts num_array.join
while topPrime==0 do
  puts "Getting pandigital numbers from #{num_array.join}."
  d = LexoPerm(num_array)
  puts "Looking for primes."
  d.each{|d| topPrime = d if d.prime? }
  num_array = num_array.slice(0,num_array.length-1)
end
puts "Answer = #{topPrime}"