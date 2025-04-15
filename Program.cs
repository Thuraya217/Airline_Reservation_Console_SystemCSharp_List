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
        static int MaxBooking = 10;
        static List<string> passengerNames = new List<string>();
        static List<string> bookingIDs = new List<string>();
        static List<int> BasePrice = new List<int>();
        //static List<string> BookedFlightCodes = new List<string>();
        static List<int> bookingCount = [];

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Airline System");

        }

        static int ShowMainMenu()
        {

            Console.WriteLine("Main Menu");
            Console.WriteLine("choose a process");
            Console.WriteLine("1. AddFlight");
            Console.WriteLine("2. Display All Flights");
            Console.WriteLine("3. Find Flight By Code");
            Console.WriteLine("4. Update Flight Departure");
            Console.WriteLine("5. Cancel Flight Booking");
            Console.WriteLine("6. Book Flight");
            Console.WriteLine("7. Validate Flight Code");
            Console.WriteLine("8. Generate Booking ID");
            Console.WriteLine("9. Display Flight Details");
            Console.WriteLine("10. Search Bookings By Destination");
            Console.WriteLine("11. Exit");

            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            return input;
        }

        static void ExitApplication()
        {
            Console.WriteLine("Thank you for using the Airline System");
            return;
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
                        Console.WriteLine("Flight limit reached");
                  }
          }

        public static void DisplayAllFlights()
        {
            if (FlightCount.Count == 0)
            {
                Console.WriteLine("No flights available.");
                return;
            }

            for (int i = 0; i < FlightCount.Count; i++)
            {
                Console.WriteLine($"Flight code: {FlightCode[i]}, From: {FromCity[i]}, To: {ToCity[i]}, Duration: {Duration[i]}, Departure Time: {DepartureTime[i]} ");
            }

        }

        public static bool FindFlightByCode(string code)
        {
            Console.Write("Enter flight code to search: ");
            string SearchCode = Console.ReadLine().ToLower();

            for (int i = 0; i < FlightCount.Count; i++)
            {
                if (FlightCode[i].ToLower() == SearchCode)
                {
                    Console.WriteLine($"Flight code: {FlightCode[i]}, From: {FromCity[i]}, To: {ToCity[i]}, Duration: {Duration[i]}, Departure Time: {DepartureTime[i]} ");
                    return true;
                }
            }
            return false;
            Console.WriteLine("Flight Not found ");
        }

        public static void UpdateFlightDeparture(ref DateTime departure)
        {
            Console.WriteLine("Enter flight code to update: ");
            string flightCode = Console.ReadLine();
            for (int i = 0; i < FlightCount.Count; i++)
            {
                if (FlightCode[i] == flightCode)
                {
                    DepartureTime[i] = departure;
                    Console.WriteLine("Flight departure updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Flight not found.");
        }

        public static void CancelFlightBooking(out string passengerName)
        {
            Console.Write("Enter flight code to cancel: ");
            string code = Console.ReadLine().ToLower();
            passengerName = "";

            bool isFound = false;

            for (int i = 0; i < FlightCount.Count; i++)
            {
                if (FlightCode[i].ToLower() == code && ProgramContinue[i])
                {
                    ProgramContinue[i] = false;
                    Console.WriteLine($"Booking for {passengerName} on flight {FlightCode[i]} has been cancelled.");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Flight not found or already cancelled.");
            }
        }

        static string BookFlight(string passengerName, string flightCode = "Default001")
        {

        }

        static bool ValidateFlightCode(string flightCode)
        {

        }
        static string GenerateBookingID(string passengerName)
        {

        }

        static void DisplayFlightDetails(string code)
        {

        }

        static void SearchBookingsByDestination(string toCity)
        {

        }

        static bool ConfirmAction(string action)

        {
            {
                Console.Write($"Are you sure you want to {action}? (y/n): ");
                string input = Console.ReadLine().ToLower();
                while (input != "y" && input != "n")
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    input = Console.ReadLine().ToLower();
                }
                return input == "y";
            }
        }

    }
}

    

