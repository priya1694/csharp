using System;

namespace Enums
{
    class Program
    { 
    enum Months
        {
            January = 1,    
            February,   
            March,      
            April,      
            May,       
            June,      
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            int mon = (int)Months.April;
            Console.WriteLine(mon);
        }
    }
}
    

