namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
   string[] inputTrucks= Console.ReadLine().Split(";").ToArray();
            List<Truck> listOfTrucks = new List<Truck>();
            foreach(string item in inputTrucks)
            {
                string[] trucks = Console.ReadLine().Split("=").ToArray();
                listOfTrucks.Add(new Truck(trucks[0], double.Parse(trucks[1])));
            }
        }
    }
}
