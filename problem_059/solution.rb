# return true if ascii value can be printed to screen
def is_printable(n)
    (n.to_i>=32 && n.to_i<=126)
end

# returns decrypted text, or "~~~" if text not completly readable.
def decrypt(cipher, key)
    ary = []
    for i in (0..cipher.count-1) do
        # "#{i} - #{cipher[i]}"
        c = cipher[i]^key[i%3]
        if is_printable(c)
            ary << c.chr
        else
            return "~~~"  # This sequence will signal decrypted text is not readable
        end
    end
    ary.join
end

# returns the sum of all the decrypted ascii values in cipher.
def sum_ascii(cipher,key)
    sum = 0
    cipher.each_index{|i| sum += cipher[i]^key[i%3]}
    sum
end

# read the data from the file into an array
file = File.read('cipher.txt')
cipher = file.split(",").map{|x|x.to_i}
min = 'a'.ord
max = 'z'.ord
keys=[]
for a in (min..max) do
    for b in (min..max) do
        for c in (min..max) do
            new_key = Array.new()
            new_key << a
            new_key << b
            new_key << c
            keys << new_key
        end
    end
end
index = 0
keys.each{|key| 
    index += 1
    str = decrypt(cipher,key)
    if str!="~~~"
        if(str =~ /[^A-Za-z0-9 _.,!"'$?();]/).nil?
            puts "#{index} [#{key.join}] - #{str}"
            puts "ASCII sum = #{sum_ascii(cipher,key)}"           
        end
    end
}