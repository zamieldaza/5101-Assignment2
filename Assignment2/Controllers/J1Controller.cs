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
        // Variables for the number of calories in burguers
        int cheeseburgerCals = 461;
        int fishBurgerCals = 431;
        int veggieBurguerCals = 420;

        // Variables for the number of calories in drinks
        int softDrinkCals = 130;
        int orangeJuiceCals = 160;
        int milkCals = 118;

        // Variables for the number of calories in side orders
        int friesCals = 100;
        int bakedPotatoCals = 57;
        int chefSaladCals = 70;

        //  Variables for the number of calories in desserts
        int applePieCals = 167;
        int sundaeCals = 266;
        int fruitCupCals = 75;

        // Variable to use when no option is selected for any of the choices
        int noCals = 0;

        // Variable to keep count of the calories
        int calCount = 0;

        /// <summary>
        /// This method computes the total calories of a meal and returns a string with this information
        /// <example>GET : api/J1/Menu/{burger}/{drink}/{side}/{dessert}</example>
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink">Integer representing the index drink choice</param>
        /// <param name="side">Integer representing the index side choice</param>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <returns>String with the total calories of the meal</returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Menu (int burger, int drink, int side, int dessert)
        {
            // Input validation
            if (burger < 1 || drink < 1 || side < 1 || dessert < 1 || burger > 4 || drink > 4 || side > 4 || dessert > 4)
            {
                return "You must input numbers between 1 and 4";
            }
            // Call the methods to determine the number of calories for each menu choice and add all of them to the final calorie count
            else
            {
                calCount += burgerCount(burger) + drinkCount(drink) + sideCount(side) + dessertCount(dessert);
                return "Your total calorie count is " + calCount;
            }
            
        }

        /// <summary>
        /// This method returns the number of calories of the chosen burguer option
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <returns>The number of calories of the chosen burguer</returns>
        public int burgerCount (int burger)
        {
            if (burger == 1)
            {
                return cheeseburgerCals;
            }
            else if (burger == 2)
            {
                return fishBurgerCals;
            }
            else if (burger == 3)
            {
                return veggieBurguerCals;
            }
            else
            {
                return noCals;
            }
        }

        /// <summary>
        /// This method returns the number of calories of the chosen drink option
        /// </summary>
        /// <param name="drink">Integer representing the index drink choice</param>
        /// <returns>The number of calories of the chosen drink</returns>
        public int drinkCount(int drink)
        {
            if (drink == 1)
            {
                return softDrinkCals;
            }
            else if (drink == 2)
            {
                return orangeJuiceCals;
            }
            else if (drink == 3)
            {
                return milkCals;
            }
            else
            {
                return noCals;
            }
        }

        /// <summary>
        /// This method returns the number of calories of the chosen side order option
        /// </summary>
        /// <param name="side">Integer representing the index side order choice</param>
        /// <returns>The number of calories of the chosen side order</returns>
        public int sideCount(int side)
        {
            if (side == 1)
            {
                return friesCals;
            }
            else if (side == 2)
            {
                return bakedPotatoCals;
            }
            else if (side == 3)
            {
                return chefSaladCals;
            }
            else
            {
                return noCals;
            }
        }

        /// <summary>
        /// This method returns the number of calories of the chosen dessert option
        /// </summary>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <returns>The number of calories of the chosen dessert</returns>
        public int dessertCount(int dessert)
        {
            if (dessert == 1)
            {
                return applePieCals;
            }
            else if (dessert == 2)
            {
                return sundaeCals;
            }
            else if (dessert == 3)
            {
                return fruitCupCals;
            }
            else
            {
                return noCals;
            }
        }

    }
}
