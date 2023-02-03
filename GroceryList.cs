using System;
using System.Collections.Generic;
// An error I encountered: I wrote collections instead of Collectons and C# gav e me a 

class GroceryList
{
    static void Main(){
        // don't forget the Main is an entry point needed for a C# code to run

        // YOU SHOULD ALWAYS NOTE: C# arrays would not accept more items in it after it has been created
        // With Lists on the other hand you can add and Remove items from a List(with the .Add() and .Remove() methods)
        // NOTE: Lists and arrays would never take in 2 different datatypes from you, they must always be the same... If you try it you get the error; cannot conver 'int' type to 'string'....
        // all of this just basically re-explains why C# is a strongly-typed language

        // back to our application now

        // creating an array of string in C# .... with the string[] we told C# we wanted to create a C# string array
        string[] theEntireArray = {"zero index", "first index", "second index", "third index"};

        // looping through this C# array to print each individual item to the C# console

        foreach (string individualItem in theEntireArray)
        // above we created a string variable that's capable of storing each individual item in itself 
        // and later on we write each item that has been stored inside this variable(individualItem) to the console
        {

            Console.WriteLine(individualItem);
        }

    
    // let us create another for each loop for our application

        // string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereal", "rice", "youghurt"};

        // // we can loop through each item in the myGroceryList like this:
        
        // foreach (string eachGrocery in myGroceryList)
        // {
        //     Console.WriteLine("My Grocery Item: " + eachGrocery);
        // }







        // LET US PRACTICE LOOPING THROUGH INTEGERS
        // WE used our previous loop here but made new updates to it
        //  we want to be able to keep track of our grocery trip's cost

        // THE MAIN REASON WHY WE ADDED AN INTEGER VARIABLE is because we want to be able display the total price at the end
        // NOT to display each item's prices..... we can update our code later on to do that, that would be 1 foreach function called upon 2 arrays
        // the first array would be the myGroceryList array(the array that contains strings) and the second array would be the groceryListPrices array(the array housing the price for each grocery)
        // I would be adding the above update very soon :)

        // AGAIN, we loop through the string array(myGroceryList) to Write to the console each item in our grocery's list
        // AND WE loop through the int array(groceryListPrices) to tell us that the price for eggs is $1, the price for milt is $6, the price for bread is $2
        // AND FINALLY our total variable helps us calculate the total Prices of all the items in our grocery List

        string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereal", "rice", "youghurt"};

        
        // WE CREATE A SECOND ARRAY int[] groceryListPrices to store the prices of myGroceriesList items
        int[] groceryListPrices = {3, 6, 4, 2, 4, 4, 2};

        Console.WriteLine("My Grocery List:");

        // we can loop through each item in the myGroceryList like this:
        
        foreach (string eachGrocery in myGroceryList)
        {
            Console.WriteLine("Grocery Item: " + eachGrocery);
        }

        // WE CREATE A NEW int varibale named total and set it to 0. it's important we do this outside the loop, otherwise it will reset to 0 at the beginning of each loop iteration
        // INSIDE THE LOOP, we update total to equal total + price.....  the "price" integer variable created represents one item in groceryListPrices as the for each loop goes through each item in the array.
        int total = 0;

        foreach(int price in groceryListPrices)
        {
            total = total + price; 
        }

        Console.WriteLine("Your total for this shopping trip will be: $" + total);

        // all of the new codes added look a bit confusing at first but ensure you go through the xomments for a proper understanding

        // THIS PATTERN WE add to a variable and re-save the new value to that variable is so common that there is an operator
        // just for that: +=.... Hence, total = total + price is the same as total += price. just like in JavaScript

    


    }

}