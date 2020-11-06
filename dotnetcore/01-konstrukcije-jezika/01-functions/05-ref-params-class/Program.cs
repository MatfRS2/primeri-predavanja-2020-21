using System;

namespace RefKeyword
{

class Complex { 

    private int real, img; 

    public Complex(int r, int i) 
    { 
        real = r; 
        img = i; 
    } 

    public int getRealValue() 
    { 
        return real; 
    } 

    public int getImgValue() 
    { 
        return img; 
    } 

    public static void Update(ref Complex obj) 
    { 
        obj.real += 5; 
        obj.img += 5; 
    } 
} 

class Program { 
    
    static void Main(string[] args) 
    { 
        Complex C = new Complex(2, 4); 
        Console.WriteLine("Complex number C = " + C.getRealValue() +  
            " + i " + C.getImgValue()); 

        Complex.Update(ref C); 
        Console.WriteLine("After updating C"); 
        Console.WriteLine("Complex number C = " + C.getRealValue() +  
            " + i " + C.getImgValue()); 
    } 

}

}