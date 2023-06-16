using System;

namespace Email_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Email Smaple Program using REGEX and Pattern!");
            ValidEmail valid = new ValidEmail();
            Console.WriteLine("Valid Email Samples are:");
            Console.WriteLine(valid.CheckValidEmail("abc@yahoo.com"));
            Console.WriteLine(valid.CheckValidEmail("abc-100@yahoo.com"));
            Console.WriteLine(valid.CheckValidEmail("abc.100@yahoo.com"));
            Console.WriteLine(valid.CheckValidEmail("abc111@abc.com"));
            Console.WriteLine(valid.CheckValidEmail("abc-100@abc.net"));
            Console.WriteLine(valid.CheckValidEmail("abc.100@abc.com.au"));
            Console.WriteLine(valid.CheckValidEmail("abc@1.com"));
            Console.WriteLine(valid.CheckValidEmail("abc@gmail.com.com"));
            Console.WriteLine(valid.CheckValidEmail("abc+100@gmail.com"));
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Invalid Email Samples are:");
            Console.WriteLine(valid.CheckValidEmail("abc"));
            Console.WriteLine(valid.CheckValidEmail("abc@.com.my"));
            Console.WriteLine(valid.CheckValidEmail("abc123@gmail.a"));
            Console.WriteLine(valid.CheckValidEmail("abc123@.com"));
            Console.WriteLine(valid.CheckValidEmail("abc123@.com.com"));
            Console.WriteLine(valid.CheckValidEmail(".abc@abc.com"));
            Console.WriteLine(valid.CheckValidEmail("abc()*@gmail.com"));
            Console.WriteLine(valid.CheckValidEmail("abc@%*.com"));
            Console.WriteLine(valid.CheckValidEmail("abc..2002@gmail.com"));
            Console.WriteLine(valid.CheckValidEmail("abc.@gmail.com"));
            Console.WriteLine(valid.CheckValidEmail("abc@abc@gmail.com"));
        }
    }
}