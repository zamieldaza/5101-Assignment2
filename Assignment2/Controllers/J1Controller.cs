using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// This method computes the total calories of a meal
        /// <example>GET : api/J1/Menu/{burger}/{drink}/{side}/{dessert}</example>
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink">Integer representing the index drink choice</param>
        /// <param name="side">Integer representing the index side choice</param>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <returns>Total calores of the meal </returns>
        public int Menu (int burger, int drink, int side, int dessert)
        {

            return 0;
        }

    }
}
