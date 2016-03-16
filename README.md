# Understanding the Demonstrator Project
The Demonstrator Project is a C# Solution intended to be a showcase for demonstration code. Presently the project contains one item to present, the class, Differentitator.

##Working with the class, Differentiator

Differentiator is a demonstration class that publishes a method, `GreatestDifference(int[] numbers)`. The purpose of `Differentiator.GreatestDifference()` is to meet the following requirement:

> Write a function that given an array of n integers, returns the largest difference in the array between a value and another value with a smaller index in the array.

###How to use Differentiator.GreatestDifference()

This method, `GreatestDifference(int[] numbers)` accepts an array of at least two integers and returns the greatest difference between an element on in that array and any elements previous to the current element being considered. For example, should the array {3,7,8,11} be submitted, the value 8 will be returned, where 11 - 3 = 8. The value, 11 is the "element of interest" and the value, 3 is an element previous to that point of interest. That 'previous element' produces the greatest difference possible when subtracted from the point of interest element, 11 . Thus, again, 11 - 3 = 8.


###How Differentiator.GreatestDifference() Works

The way the method `GreatestDifference(int[] numbers)` works is by using an algorithm that iterates through each element in the submitted array. (Figure 1, below shows a sample array with seven elements that has the values, 12, -1, 5, 9, 100, 47, -8, 11.)

![](https://github.com/reselbob/Demonstrator/blob/master/images/GetGreatestDifference-01.jpeg?raw=true)

**Figure 1: Differentiator.GreatestDifference() find the value the is the largest difference among two elements in a submitted array.**

During iteration, the code traverses back through elements previous to the current element in iteration. The code subtracts a previous element from the current "element of interest" to produce a difference. That difference is compared to the last `greatDifference` discovered. (`greatestDifference` is a value global to the method.) If this new difference is larger than the current `greatestDifference`, the new value is assigned to `greatDifference`. (Please Figure 2, below.)

![](https://github.com/reselbob/Demonstrator/blob/master/images/GetGreatestDifference-02.jpeg?raw=true)

**Figure 2: There can be only value for greaesttDifference in the method, Differentiator.GreatestDifference().**  

The `greatestDifference` that is in force, after all the elements in the submitted array have be examined, is the value returned by the method.

###Opportunities for Improvement
This version is preliminary and meets the conditions described in the purpose at the beginning of this README. The method has been verified according to the unit tests in the Test Project that is part of this repository's solution.

The most glaring opportunity for improvement is to determine a more efficient way to iterate through the array submitted to discover the Greatest Difference.

Also, presently the method, `Differentiator.GreatestDifference(`) does not support the notion of [absolute value](https://www.mathsisfun.com/numbers/absolute-value.html) comparison. Such comparison might prove useful should the need arise later on.