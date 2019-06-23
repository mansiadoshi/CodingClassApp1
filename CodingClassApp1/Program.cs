using System;

namespace CodingClassApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Object Initialization where you assign values when instantiating the class first time itself
            var CSharpClass_Sunday = new CSharpClass()
            {
                DurationOfClass = 12,
                ClassFee = 420.00
                
            };
            Console.WriteLine($"QCd: {CSharpClass_Sunday.QRCode}, Fee: {CSharpClass_Sunday.ClassFee:C}, SD:{CSharpClass_Sunday.StartDate}");
            
            

        }
    }
}
