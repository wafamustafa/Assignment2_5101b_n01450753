using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01450753_Wafamustafa_GroupB.Controllers
{
    public class JController : ApiController
    {
        /// <summary>
        /// add all the calorie count by the options the customer chooses using 4 parameter.
        /// we would have to create an array for each category with the calorie count for each option within the category
        /// </summary>
        /// <array>burgerChoice, drinkChoice, sideChoice, dessertChoice</array>
        /// <paramref name="burger"/> is now the index option for burgerChoice
        /// <paramref name="drink"/> is now the index option for drinkChoice
        /// <paramref name="side"/> is now the index option for sideChoice
        /// <paramref name="dessert"/> is now the index option for dessertChoise
        /// <result>api/J1/Menu/4/4/4/4 ----> 0 cals"</result>
        [HttpGet]
        [Route ("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            //create arrays
            int[] burgerChoice = { 461, 431, 420, 0 };
            int[] drinkChoice =  { 130, 160, 118, 0 };
            int[] sideChoice = { 100, 57, 70, 0 };
            int[] dessertChoice = { 167, 266, 75, 0 };

            // index represented by the parameters within the public string "menu"
            // index start at 0 so we sub 1 since choice start at 1 to get the right index number
            int CalorieCount = burgerChoice[burger - 1] + drinkChoice[drink - 1] + sideChoice[side - 1] + dessertChoice[dessert - 1];

            // return message is in a string, new variable for "message" to keep return code cleaner
            string message = "Your total calorie count is ";
            // concat the total calorie count of the users options 
            return message + CalorieCount;
           
        }
        /// <summary>
        /// By getting random number of sides for 2 dice we have to get the number of ways we can get the sum of 10
        /// </summary>
        /// <param name="m">give us the number of sides is dieOne</param>
        /// <param name="n">gives us number of sides in dieTwo</param>
        /// <example>m = 6 && n = 8 g---> 5 ways to get the sum of 10 </example>
        /// <example>m = 12 && n = 4 ----> 4 ways to get 10 </example>
        /// <returns>count++ returns the value of ways to get the given sum </returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            //count of ways start at 0
            int count = 0;
            //string message for cleaner return code 
            string message1 = "There are ";
            string message2 = "ways to get the sum of 10";
            //iniator:the first die intial value will start at 1 
            //condition:whatever the die side value it should be less than or equal to
            //increment: going up by 1 to judge every value
            for (int i = 1; i <= m; i++)
            {
                //nest is a loop of the second die: same concept as above  
                for (int v = 1; v <= n; v++)
                {
                    //if statment to give the loops a condition when to stop running or it will cause an infinate loop
                    if ((i + v) == 10)
                    {
                        //counter of all the rolls with the given sides to reach the sum of 10
                        count++;

                    }
                }
            }
            //self explantory....
            return message1 + count + message2;

        }
    }
}

/* J3: Cell phone messaging
 * array for all alphabets that would include where the are on the keypad
 * <example> a[2],b[22],c[222]...</example>
 * single digit index will add a second and double digit number will add 2 seconds and so on.
 * <example> a[2] = 1, b[22]= 2, c[222]= 3</example>
 * <ref>https://www.programiz.com/c-programming/c-arrays</ref>
 * a variable for pause which will add 2 seconds
 * first loop will check to see what number has been press which will correspond with the index number
 * nested loop for the pause incrementing up by i + 2
 * if statement with condition for repeat characters in one line to add in another pause (count +2)
 * drink of water because I'm officially overwhelmed just writing down my train of thought
 * wafa = 9-pause-2-pause-333-pause-2 ---> 12 seconds?
 * I'm not sure if I'm going in the right direction here or if I've gone off on a tangent. In any case I sincerely apologize I'm not sure if im going in the right direction her or if I've gone off in a tangiant. In any case I sincerly apologize 
*/

