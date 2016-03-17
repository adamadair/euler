  # quicker solution
  a = Array.new(31, 0)
	a[0]=0
	a[1]=3   #one
	a[2]=3   #two
	a[3]=5   #three
	a[4]=4   #four
	a[5]=4   #five
	a[6]=3   #six
	a[7]=5   #seven
	a[8]=5   #eight
	a[9]=4   #nine
	a[10]=3  #ten
	a[11]=6  #eleven
	a[12]=6  #twelve
	a[13]=8  #thirteen
	a[14]=8  #fourteen
	a[15]=7  #fifteen
	a[16]=7  #sixteen
	a[17]=9  #seventeen
	a[18]=8  #eighteen
	a[19]=8  #nineteen
	a[20]=6  #twenty
	a[21]=6  #thirty
	a[22]=5  #forty
	a[23]=5  #fifty
	a[24]=5  #sixty
	a[25]=7  #seventy
	a[26]=6  #eighty
	a[27]=6  #ninety
	a[28]=3  #and
	a[29]=7  #hundred
	a[30]=8  #thousand<--is this really needed?
  j = 0
  for i in 1..999
    j+=a[i/100]+a[29]+a[28] if((i/100)!=0)
    if(i%100>20)
			j+=a[18+(i%100)/10]+a[i%10]
		else
      puts i
			j+=a[i%100]
    end
  end
	j+=a[i/1000]+a[30];
	puts("#{j-24}")