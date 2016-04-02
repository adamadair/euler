i = 345
cube_hash = {}
begin
  i += 1
  cube = i**3
  cube_key = cube.to_s.chars.sort.join
  if cube_hash.key? cube_key
    cube_hash[cube_key][:permutations] += 1
  else
    cube_hash[cube_key] = {
      smallest_cube: cube,
      permutations: 1
    }
  end
end until cube_hash[cube_key][:permutations] == 5
puts cube_hash[cube_key][:smallest_cube]