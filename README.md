# Vendigo Vending Management System

You work for the giant, multi-national corporation of Vendigo Vending. Vendigo distributes and manages vending machines in Spain, Japan, and the United States. You have been tasked with building a simulation for purchasing items at vending machines in any of those countries. Here are the business constraints that you must take into account while building it.

## Food Types

Vendigo produces highly specialized vending machines where each one only holds specific kinds of foods. You must ensure that each vending machine only contains items of the corresponding type.

* Sodas (Coke, Pepsi, Mountain Dew, RC Cola, etc.)
* Coffees (Espresso, Americano, Latte, Cafe Con Leche, etc.)
* Candies (Snickers, Mokomoko, Konpeito, Baby Ruth, Pikota, Lacasitos, etc.)
* Prepared meals to be heated (Burgers, Ramen, Paella, etc.)
* Energy drinks (Monster, Red Bull, Flaming Moe, Zombie Pacman, etc.)
* Clothing (Socks, underwear, ties, gloves, air filter, etc.)
* Sundries (Tissue, batteries, tweezers, antacids, etc.)

## Requirements

1. Each vending machine must maintain a list of current stock.
1. Each vending machine must maintain a list of sold items.
1. Each vending machine must have a method to purchase an item. It takes input of the amount of cash the user put into the machine. It must return the amount of change to give back to the user.
1. Each vending machine must ensure that the current stock does not exceed the recommended capacity.
1. Each vending machine must have a method to record a sale. It should take a product item as input and store it in the sold items list.

## User Interface

When you run the application, you should first present a list of countries for the user to choose from. Also provide an option to show reports, or exit.

```sh
1. Japan
2. Spain
3. United States
4. Display reports
5. Exit

Choose a country
> _
```

After the user has chosen a country, display the vending machines that sell items for that country.

```sh
1. Prepared meals
2. Candies
3. Clothing
4. Energy drinks

What kind of product would you like to purchase?
> _
```

After selecting vending type, list items of that type that are sold in that country. You must use the appropriate locale currency symbol to display the price of the item.

```sh
1. Mokomoko ¥9
2. Konpeito ¥8
3. Tezukuri Apollo ¥9
4. Mango Ginger Chews ¥11
5. Koala’s March Chocolate ¥12
6. Kasugai Peach Gummy ¥10

Which Candy would you like to purchase?
> _
```

Then prompt the user for how much cash they will be putting into the machine.

```sh
The Mokomoko costs ¥9. What denomination will you be using?
> _
```

Then display the change.

```sh
You spent ¥20. Your change is ¥11. Thank you for your purchase.
```

## Reports

If the user chose the main option to display reports, here's the information you should write to the terminal.

1. Top 10 items sold worldwide by count.
1. Top 10 item types sold worldwide by count.
1. Top 10 items sold worldwide by revenue.
1. Top 10 items sold by revenue per country.

