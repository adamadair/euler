#max=1939495969798999999
#min=1000000000000000000
n=1010101010
while n <= 1414213562 do
  val = n**2
  if(val%10==0)
    chars = val.to_s.chars
    if chars[0]=='1' && chars[2]=='2' && chars[4]=='3' && chars[6]=='4' && chars[8]=='5' && chars[10]=='6' && chars[12]=='7' && chars[14]=='8' && chars[16]=='9' && chars[18]=='0'
      puts n
      break
    end  
  end
  n+=1
end
puts "done"
