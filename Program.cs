﻿using System;

public class Calculator
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2)
    {
        if (num2 != 0)
            return num1 / num2;
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return double.NaN; // NaN represents "Not a Number"
        }
    }
Console.WriteLine("Hej Nicke!");
Console.WriteLine("/ff 15");
}

//Jag heter Jesper och är challanger på LoL