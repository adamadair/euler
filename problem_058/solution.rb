require "../lib/ruby/is_prime"
# returns n/total as percent
def calc_percent(n, total)
  (n.to_f/total.to_f) * 100.0
end

total = 0
primes = 0
edge = 1
begin
  edge += 2
  ne = (edge**2)
  nw = ne - (edge - 1)
  sw = nw - (edge - 1)
  se = sw - (edge - 1)
  total += 4
  # Obviously no reason to ever check ne 
  primes += 1 if nw.prime?
  primes += 1 if sw.prime?
  primes += 1 if se.prime?
end until calc_percent(primes, total) <= 10.0
puts edge
