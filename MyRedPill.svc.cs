using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [ServiceBehavior(Namespace = Constants.Namespace)]
    public class MyRedPill : IRedPill
    {
        /// <summary>
        /// Whats the is your token.
        /// </summary>
        /// <returns></returns>
        public Guid WhatIsYourToken()
        {
            return new Guid("a5055c93-35b2-465c-a07b-51935be1a752");
        }

        /// <summary>
        /// Product the sum of a Fibonacci series given a number.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public long FibonacciNumber(long n)
        {
            var sqrt5 = Math.Sqrt(5);
            var phi = (1 + sqrt5) / 2;

            var result = (Math.Pow(phi, n) - Math.Pow(-phi, -n)) / sqrt5;

            if (Double.IsInfinity(result))
                throw new ArgumentOutOfRangeException();
            
            return (long) result;
        }

        /// <summary>
        /// Identify the type of a triangle given 3 lengths.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            TriangleType result = TriangleType.Error;

            if ((a + b + c) <= 0 || a <= 0 || b <= 0 || c <= 0)
                return result;

            if (a == b && a == c)
            {
                return TriangleType.Equilateral;
            }
            else if (a != b && b != c && a != c)
            {
                return TriangleType.Scalene;
            }
            else
            {
                return TriangleType.Isosceles;
            }
        }

        /// <summary>
        /// Reverses the words in a given string.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public string ReverseWords(string s)
        {
            if (s == null)
                throw new ArgumentNullException();

            if (s.Trim().Length == 0 || s.Length == 1)
                return s;

            string result = "";
            string[] words = s.Trim().Split(' ');

            foreach (var word in words)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);

                result = string.Format("{0} {1}", result, new String(charArray));
            }

            return result.Trim();
        }
    }
}
