﻿/*
private Accessibility Level

Access is only granted to the containing class. 

Any other class inside the current or another assembly is not granted access to 
these members.
*/
using System; 

namespace PrivateAccessModifier { 

class Roditelj { 

    // Member is declared as private 
    private int value; 

    // value is Accessible  
    // only inside the class 
    public void setValue(int v) 
    { 
        value = v; 
    } 

    public int getValue() 
    { 
        return value; 
    } 
} 

class Potomak : Roditelj { 

    public void ShowValue() 
    { 
        // Trying to access value 
        // Inside a derived class 
        // Console.WriteLine( "Value = " + value ); 
        // Gives an error 
    } 
} 

class Program { 

    static void Main(string[] args) 
    { 
        Roditelj obj = new Roditelj(); 

        // obj.value = 5; 
        // Also gives an error 

        // Use public functions to assign 
        // and use value of the member 'value' 
        obj.setValue(4); 
        Console.WriteLine("Value = " + obj.getValue()); 
    } 
} 

