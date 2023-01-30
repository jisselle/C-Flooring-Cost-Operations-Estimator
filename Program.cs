namespace Flooring_Cost_Estimator_App_1_JG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double FeetPerHour = 40;
            const double CostPerHour = 35.75;

            Console.WriteLine("Garcia's Flooring Cost Estimator:\n");

            // Getting Inputs
            Console.Write("Please enter length of floor: ");
            int.TryParse(Console.ReadLine(), out int flooringLength);


            Console.Write("Please enter width of floor: ");
            int.TryParse(Console.ReadLine(), out int flooringWidth); 

            Console.Write("Please enter the cost per square foot for the flooring selected: ");
            double.TryParse(Console.ReadLine(), out double flooringCost);

            Console.WriteLine("------------------------------");

            //Calculations 
            int totalSquareFeet = flooringLength * flooringWidth;
            double totalFlooringCost = totalSquareFeet * flooringCost;

            double totalHours = totalSquareFeet / FeetPerHour;
            double installCost = totalHours * CostPerHour;

            double totalCost = totalFlooringCost + installCost;

            Console.WriteLine($"For a total floor size of {totalSquareFeet} the flooring cost is: {totalFlooringCost:c}");
            Console.WriteLine($"It will take {totalHours:n2} hours to install the floor at a cost of: {installCost:c}\n");
            Console.WriteLine($"The total cost for the new floor is {totalCost:c}");

            Console.ReadLine();
        }
    }
}