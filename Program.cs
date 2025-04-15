namespace Airline_Reservation_Console_SystemCSharp_List
{
    internal class Program
    {
        static int MaxFlight = 10;
        static List<string> FlightCode = new List<string>();
        static List<string> FromCity = new List<string>();
        static List<string> ToCity = new List<string>();
        static List<DateTime> DepartureTime = new List<DateTime>();
        static List<int> Duration = new List<int>();
        static List<int> FlightCount = [];
        static List<bool> ProgramContinue = new List<bool>();
        

        //booking
        static List<string> passengerNames = new List<string>();
        static List<string> bookingIDs = new List<string>();
        static List<int> BasePrice = new List<int>();
        static List<int> bookingCount = [];

        static void Main(string[] args)
        {
        
        }
        
          public static void AddFlight(string flightCode, string fromCity, string toCity, DateTime departureTime, int duration, int basePrice)
        {
            if (FlightCount.Count < 100)
            {
                FlightCode.Add(flightCode);
                FromCity.Add(fromCity);
                ToCity.Add(toCity);
                DepartureTime.Add(departureTime);
                Duration.Add(duration);
                BasePrice.Add(basePrice);
                FlightCount.Add(1);
                Console.WriteLine("Flight added successfully.");
            }
            else
            {
                Console.WriteLine("There is not space for add more flight ");
            }
        }
    }
}

    

