using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// This method returns the number of ways you can roll the value of 10 with two dices with variable sides
        /// </summary>
        /// <param name="m">positive integer representing the number of sides on the first die</param>
        /// <param name="n">positive integer representing the number of sides on the second die</param>
        /// <returns>A string with the number of ways you can roll 10 with the two specified dices</returns>
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public string DiceGame(int m, int n)
        {
            // Variable that holds the number of ways 10 can be rolled with the specified dices
            int numberOfWays = 0;
            // Input validation
            if (m < 1 || n < 1 )
            {
                return "Please input valid values - both numbers must be positive integers";
            }
            else
            {
                for (int i = 1; i <= m; i++)
                {
                    for (int i1 = 1; i1 <= n; i1++)
                    {
                        int sum = i + i1;
                        if (sum == 10)
                        {
                            numberOfWays++;
                        }
                    }
                }

                // Change return depending on the number of ways
                if (numberOfWays == 1)
                {
                    return "There is " + numberOfWays + " way to get the sum 10.";
                }
                else
                {
                    return "There are " + numberOfWays + " ways to get the sum 10.";
                }
            }            
        }
    }
}
