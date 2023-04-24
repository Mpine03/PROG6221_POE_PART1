using System;
namespace recipeApp
{
    class recipe
    {
        string[] nameOfIngredient;
        double[] quantity;
        string[] unitOfMeasurement;
        string[] steps;

        public recipe()
        {
            nameOfIngredient = new string[0];
            quantity = new double[0];
            unitOfMeasurement = new string[0];
            steps = new string[0];
        }
        public void userInput()
        {
            Console.WriteLine("How many ingredients are you going to use?");
            int numOfIngredients = Convert.ToInt32(Console.ReadLine());

            nameOfIngredient = new string[numOfIngredients];
            quantity = new double[numOfIngredients];
            unitOfMeasurement = new string[numOfIngredients];
            steps = new string[numOfIngredients];

            for (int i = 0; i < numOfIngredients; i++)
            {
                Console.WriteLine($"Enter the name,quantity and the unit of measurement of your ingredients #{i + 1}:");

                Console.WriteLine("Name of Ingedient:");
                nameOfIngredient[i] = Console.ReadLine();

                Console.WriteLine("Quantity of the ingredient:");
                quantity[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Unit of Measurement:");
                unitOfMeasurement[i] = Console.ReadLine();
            }

            Console.WriteLine("How many steps are there going to be in your recipe?");
            int numOfSteps = Convert.ToInt32(Console.ReadLine());

            steps = new string[numOfSteps];

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.WriteLine($"Write a description of what the user should do ( Step number_{i + 1}):");
                steps[i] = Console.ReadLine();
            }
        }
        public void recipeOutput()
        {
            Console.WriteLine("Recipe Ingredients:");
            for (int i = 0; i < nameOfIngredient.Length; i++)
            {
                Console.WriteLine($"{quantity[i]} {unitOfMeasurement[i]} of {nameOfIngredient[i]}");
            }

            Console.WriteLine("Recipe Steps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"STEP_{i + 1}.{steps[i]}");
            }

        }
        public void scaling(double factor)
        {
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] *= factor;
            }
        }
        public void resetQuantities()
        {
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] /= 2;
            }
        }
        public void clearData()
        {
            nameOfIngredient = new string[0];
            quantity = new double[0];
            unitOfMeasurement = new string[0];
            steps = new string[0];
        }

    }
    class Execute
    {
        public static void Main(string[] args)
        {
            recipe rec = new recipe();

            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("How to use this application:");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("To input the recipe details, enter '1'");
                Console.WriteLine("To output the full recipe, enter '2'");
                Console.WriteLine("To scale the recipe, enter '3'");
                Console.WriteLine("To reset the quantity of the ingredients, enter '4'");
                Console.WriteLine("To clear all the data of the recipe, enter '5'");
                Console.WriteLine("To exit, enter '6'");
                Console.WriteLine("--------------------------------------------------------------");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        rec.userInput();
                        break;

                    case "2":
                        rec.recipeOutput();
                        break;

                    case "3":
                        Console.WriteLine("Enter a scaling factor: 0.5, 2 or 3");
                        double factor = Convert.ToDouble(Console.ReadLine());
                        rec.scaling(factor);
                        break;

                    case "4":
                        rec.resetQuantities();
                        break;

                    case "5":
                        rec.clearData();
                        break;

                    case "6":
                        Console.WriteLine("Closing Application...");
                        return;
                    default:
                        Console.WriteLine("Invaild option. Enter the correct option.");
                        break;

                }



            }
        }
    }
}
