require "../lib/ruby/is_prime"
def get_prime_list
  ary=[]
  i = 65001
  begin
    ary << i if i.prime?
    i += 2
  end until i > 999999
  ary
end

def temp_perm(template, x, &block)
  if template == template.sub('x', x)
    block.call(template) if template =~ /X/ 
  else
    temp_perm(template.sub('x', 'X'), x, &block)
    temp_perm(template.sub('x', x), x, &block)
  end
end

def int_to_temp(x)
  str = x.to_s
  (0..9).each do |i|
    ch = i.to_s
    template = str.gsub(ch, 'x')
    next if template == str 
    temp_perm(template, ch.to_s) do |tpl|
      yield tpl
    end
  end
end

max_count = 0
temp_counts = {}
found_template = nil

prime_list = get_prime_list()

prime_list.each{ |prime|
  int_to_temp(prime) do |template|
    temp_counts[template] ||= 0
    temp_counts[template] += 1
    if temp_counts[template] > max_count
      max_count = temp_counts[template]
      if max_count == 8
        found_template = template
        break
      end
    end
  end
  break if found_template
}

smallest_prime = nil
(0..9).each do |i|
  number = found_template.gsub('X', i.to_s).to_i
  smallest_prime = number
  (2..(number**0.5)).each do |j|
    if number % j == 0
      smallest_prime = nil
    end
  end
  break if smallest_prime
end

puts smallest_prime