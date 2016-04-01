def add_at_front(ary, d)
  ary.insert(0,d) if ary.include?(d)==false
end

def add_after(ary,d,c)
  if ary.include?(d)
    # make sure it comes after c
    if ary.index(d)<ary.index(c)
      ary.delete(d)
      ary.insert(ary.index(c)+1,d)
    end
  else
    # insert after c
    ary.insert(ary.index(c)+1,d)
  end
end
  
digarray = []
File.open("keylog.txt", "r") do |f|
  f.each_line do |line|
    chars = line.chars
    add_at_front(digarray, chars[0])
    add_after(digarray,chars[1],chars[0])
    add_after(digarray,chars[2],chars[1])
  end
end

puts digarray.join