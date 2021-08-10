using System;

namespace CodeSmells.examples
{
    // the following example was inspired by this article:
    // https://avraam.dev/posts/code-smell-feature-envy
    namespace RefusedBequest.Problem
    {
        public class PhoneNumber
        {
            public string UnformattedNumber { get; set; }

            public string GetAreaCode()
            {
                return UnformattedNumber.Substring(0, 3);
            }

            public string GetPrefix()
            {
                return UnformattedNumber.Substring(3, 3);
            }

            public string GetNumber()
            {
                return UnformattedNumber.Substring(6,3);
            }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public PhoneNumber PhoneNumber { get; set; }

            public void PrintPhoneNumber()
            {
                Console.WriteLine("(" + PhoneNumber.GetAreaCode() + ")" + 
                                        PhoneNumber.GetPrefix() + "-" + 
                                        PhoneNumber.GetNumber());
            }
        }
    }
    
    namespace RefusedBequest.Solution
    {
        public class PhoneNumber
        {
            public string UnformattedNumber { get; set; }

            public string GetAreaCode()
            {
                return UnformattedNumber.Substring(0, 3);
            }

            public string GetPrefix()
            {
                return UnformattedNumber.Substring(3, 3);
            }

            public string GetNumber()
            {
                return UnformattedNumber.Substring(6,3);
            }

            public void PrintPhoneNumber()
            {
                Console.WriteLine("(" + GetAreaCode() + ")" +
                                        GetPrefix() + "-" +
                                        GetNumber());
            }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public PhoneNumber PhoneNumber { get; set; }

            public void PrintPhoneNumber()
            {
                PhoneNumber.PrintPhoneNumber();
            }
        }
    }
}