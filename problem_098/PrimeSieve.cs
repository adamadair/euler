using System;
using System.Collections.Generic;

namespace problem_098
{
    /// <summary>
    /// The PrimeSieve class is an implementation of the sieve of Eratosthenes. The underlying
    /// data structure only stores values pertaining to odd numbers, so it is generally 
    /// half the amount of memory used for the upper bounds of the sieve. However, it is
    /// generally a good idea to keep the sieve size under 1000000000 or so. I have not
    /// tested it for sieves greater than a billion.
    /// </summary>
    public class PrimeSieve
    {
        private bool[] sieve;
        private List<int> primes;
        private int limit;
        
        public PrimeSieve(int size)
        {
            limit = size;
            primes = new List<int>();
            initSieve();
        }

        private void initSieve()
        {
            int sieveBound = (limit - 1) / 2; // last index of sieve
            sieve = new bool[sieveBound + 1]; // auto initialized to false

            int crossLimit = Convert.ToInt32((Math.Floor(Math.Sqrt(limit)) - 1) / 2);

            for (int i = 1; i <= crossLimit; ++i)
            {
                if (!sieve[i])
                {
                    for (int j = 2 * i * (i + 1); j <= sieveBound; j += 2 * i + 1)
                    {
                        sieve[j] = true;
                    }
                }
            }
        
            for (int i = 2; i <= sieveBound; ++i)
            {
                if (!sieve[i])
                    primes.Add(i);
            }
        }

        public List<int> Primes()
        {
            return primes;
        }
        
    }
}
