using System;

namespace Reselbob.Demonstrator
{
    /// <summary>
    /// A utility class that provided differencing algorithms.
    /// </summary>
    public class Differentiator
    {
        /// <summary>
        /// This method accepts an array of at least two integers and returns the
        /// greatest difference between an element on in that array and any previous
        /// elements. For example, should the array {3,7,8,11} be submitted, the value
        /// 8 will be returned, where 11 - 3 = 8. The value, 11 is the "element of interest"
        /// and the value, 3 is an element previous to that point of interest.
        /// </summary>
        /// <param name="numbers">An array of integers to process</param>
        /// <returns>An integer the is the largest difference determined from any
        /// element in the array with any previous element subtracted,</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int GreatestDifference(int[] numbers)
        {
            if (numbers.Length <= 1)// Check for an exception
            {
                var str = string.Format("The array you subitted has only a {0} element. ", numbers.Length);
                str = str + "This method requires arrays that have at least 2 elements.";
                throw new ArgumentException(str);
            }
            //Start at the beginning of the array and diff
            // elements, moving down through previous elements and 
            //subtracting the given previous element

            var biggestDiff = 0; //The biggest number comparator
            for (var i = 1; i < numbers.Length; i++) //this is the top of the inspection
            {
                //Go down to all the elements before this one and diff according to the top one
                var downCounter = i - 1;
                do
                {
                    var diff = numbers[i] - numbers[downCounter];
                    if (diff > biggestDiff) biggestDiff = diff;
                    downCounter--;
                } while (downCounter >= 0);
            }
            return biggestDiff;
        }
    }
}