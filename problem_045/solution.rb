tri={}
pen={}
hex={}
(1..100000).select{|n|
  tri[(n*(n+1))/2]=1
  pen[(n*((3*n)-1))/2]=1
  hex[n*((2*n)-1)]=1
}
hex.keys.each{|key| puts key if tri[key]==1 && pen[key]==1}
