/*
public Accessibility Level

Access is granted to the entire program. This means that another method or 
another assembly which contains the class reference can access these members or 
types. 

This access modifier has the most permissive access level in comparison to all 
other access modifiers.
*/
using System;

namespace PublicAccessModifier
{



class Program {  
    
    // Main Method 
    static void Main(string[] args) 
    { 
        // Creating object of the class Student 
        Student S = new Student(1, "Astrid"); 

        // Displaying details directly 
        // using the class members 
        // accessible through another method 
        Console.WriteLine("Roll number: {0}", S.rollNo); 
        Console.WriteLine("Name: {0}", S.name); 

        Console.WriteLine(); 

        // Displaying details using  
        // member method also public 
        Console.WriteLine("Roll number: {0}", S.getRollNo()); 
        Console.WriteLine("Name: {0}", S.getName()); 
    } 
} 

}
