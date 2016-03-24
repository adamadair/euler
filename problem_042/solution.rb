require 'json'
require "../lib/ruby/letter"
l = Letter.new
file = File.read('p042_words.json')
words = JSON.parse(file)
tri={}
(1..1000).select{|n|tri[(0.5*n*(n+1)).to_i]=1}
count = 0 
words.each{|w| count +=1 if tri[l.word_value(w)]==1 }
puts count

