using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Linq;


//Objective: LINQ and Collections

//Task: Use Linq to search the following collection.

//Build Specifications:
//Create the following array
int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

//Write code using Linq to answer the following questions: 

//Find the Minimum value
var findMinValue = nums.Min();
//Find the Maximum value
var findMaxValue = nums.Max();
//Find the Maximum value less than 10000
var maxValLess = nums.Select(y => y < 10000);

//Find all the values between 10 and 100
var allVal = nums.All(x => (x > 10) && (x < 10000));

//Find all the Values between 100000 and 999999 inclusive 
var allValBetweenInc = nums.All(x => (x > 100000) && (x < 999999));

//Count all the even numbers   
var countAllValEvenNumbers = nums.Where(n => n % 2 == 0).Count();