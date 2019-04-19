using System;

namespace Game
{
    public class CountrySelect
    {
        public void America()
        {
            Console.WriteLine($@"
                ----------------
                AMERICAN VENDING
                ----------------
                1. Soda
                2. Candy
                3. Sundry
                4. Coffee
                5. Clothing
                6. Prepared Foods
                7. Energy Drinks

                to go back, type return
                to exit, type exit
                ");
        }
        public void Spain()
        {
            Console.WriteLine($@"
                ---------------
                SPANISH VENDING
                ---------------
                1. Soda
                2. Candy
                3. Sundry
                4. Coffee
                5. Clothing
                6. Prepared Foods
                7. Energy Drinks

                to go back, type return
                to exit, type exit
                ");
        }
        public void Japan()
        {
            Console.WriteLine($@"
                ----------------
                JAPANESE VENDING
                ----------------
                1. Soda
                2. Candy
                3. Sundry
                4. Coffee
                5. Clothing
                6. Prepared Foods
                7. Energy Drinks

                to go back, type return
                to exit, type exit
                ");
        }
    }
}