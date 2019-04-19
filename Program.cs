using System;

namespace Vendigo
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate vending machines
            CandyVendingMachine CandyVM = new CandyVendingMachine();
            ClothingVendingMachine ClothingVM = new ClothingVendingMachine();
            CoffeeVendingMachine CoffeeVM = new CoffeeVendingMachine();
            EnergyDrinkVendingMachine EnergyVM = new EnergyDrinkVendingMachine();
            PreparedFoodVendingMachine PreparedFoodVM = new PreparedFoodVendingMachine();
            SodaVendingMachine SodaVM = new SodaVendingMachine();
            SundryVendingMachine SundryVM = new SundryVendingMachine();

            // instantiate products
            // candy products
            Snickers snickers = new Snickers() {Name = "Snickers Bar", Price = 1.99};
                snickers.Ingredients = "chocolate and some other stuff";
                snickers.Recyclable = false;

            CandyVM.AddProduct(snickers);

            // clothing items
            Shoes sandals = new Shoes() {Name = "Rainbow Flip-flops", Price = 80.00};
                sandals.LvlSpicy = 1;
                sandals.Organic = true;

            ClothingVM.AddProduct(sandals);

            // coffee products
            SpanishCoffee spanishCoffee = new SpanishCoffee() {Name = "Spanish Coffee Cocktail", Price = 10.00};
                spanishCoffee.LvlSpicy = 4;
                spanishCoffee.Organic = false;

            CoffeeVM.AddProduct(spanishCoffee);

            // energy drinks
            Toughman toughman = new Toughman() {Name = "Tougman", Price = 2.85};
                toughman.Colors = "yellow 2, red 4";
                toughman.RfIdFrequency = "3.16MgHz";

            EnergyVM.AddProduct(toughman);

            // prepared foods
            KrystalSlider sliders = new KrystalSlider() {Name = "Krystal Sliders", Price = 5.00};
                sliders.Ingredients = "who knows";
                sliders.Recyclable = false;

            PreparedFoodVM.AddProduct(sliders);

            // soda drinks
            Coke coke = new Coke() {Name = "Coca Cola", Price = 1.99};
                coke.Ingredients = "water, sugar, brown";
                coke.Recyclable = true;

            SodaVM.AddProduct(coke);



            Console.WriteLine($@"
            ------------------
            WELCOME TO VENDIGO!
            ------------------
            1. Japan
            2. Spain
            3. United States
            4. Display Reports
            5. Exit

            Choose a country..");
            Console.ReadKey();

        }
    }
}
