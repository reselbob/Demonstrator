# Undertanding the Demonstrator Project
A project for demonstrating a variety of coding techniques

##Working with the class, Differentiator

Differentiator is a demonstration class that publishes a method, GreatestDifference(int[] numbers). The purpose of Differentiator.GreatestDifference() is to meet the requirement:

> Write a function that given an array of n integers, returns the largest difference in the array between a value and another value with a smaller index in the array.

###How to use Differentiator.GreatestDifference()

This method, GreatestDifference(int[] numbers) accepts an array of at least two integers and returns the greatest difference between an element on in that array and any previous elements. For example, should the array {3,7,8,11} be submitted, the value 8 will be returned, where 11 - 3 = 8. The value, 11 is the "element of interest" and the value, 3 is an element previous to that point of interest that produces the greatest difference when subtracted from the point of interest element, 11 . Thus, again, 11 - 3 = 8.


###How Differentiator.GreatestDifference() Works

The way the method GreatestDifference(int[] numbers) works is by an algorithm that iterates through each element in the submitted array. 

![](https://github.com/reselbob/Demonstrator/blob/master/images/GetGreatestDifference-01.jpeg?raw=true)
During iteration, the code traverses by through elements previous the current element in iteration. The code subtracts a previous element from the current "element of interest" to produce a difference. That difference is compared to last GreatDifference discovered. (GreatestDifference is a value global to the method.) If this new difference is larger than the current GreatestDifference, the new value is assigned to GreatDifference.

![](https://github.com/reselbob/Demonstrator/blob/master/images/GetGreatestDifference-02.jpeg?raw=true)

The GreatestDifference that is in force, after all the elements in the submitted array have be examined is the value returned by the method.

###Opportunities for Improvement
This version is preliminary and meets the conditions described in the purpose. The method has been verified according to the unit tests in the Test Project that is part of this repositories solution.

The most glaring opportunity for improvement is to determine a more efficient way to iterate through the array submitted to discover the Greatest Difference.

Also, presently the method, Differentiator.GreatestDifference() does not support the notion of [absolute value](https://www.mathsisfun.com/numbers/absolute-value.html) comparison. Such comparison might prove useful should the need arise.