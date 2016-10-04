using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Collections;

namespace StockConsoleApplication
{
    class Program
    {

        IList<Stock> _stocks = new List<Stock>();

        public Program() {
            _stocks.Add(new Stock("LUL", 10000, 100));
            _stocks.Add(new Stock("ELO", 4000, 200));
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Run();
        }


        public void ShowTitle()
        {
            Console.WriteLine(" __ _             _        _               _ _           _   _             ");
            Console.WriteLine("/ _\\ |_ ___   ___| | __   /_\\  _ __  _ __ | (_) ___ __ _| |_(_) ___  _ __  ");
            Console.WriteLine("\\ \\| __/ _ \\ / __| |/ /  //_\\| '_ \\| '_ \\| | |/ __/ _` | __| |/ _ \\| '_ \\ ");
            Console.WriteLine("_\\ \\ || (_) | (__|   <  /  _  \\ |_) | |_) | | | (_| (_| | |_| | (_) | | | |");
            Console.WriteLine("\\__/\\__\\___/ \\___|_|\\_\\ \\_/ \\_/ .__/| .__/|_|_|\\___\\__,_|\\__|_|\\___/|_| |_|");
            Console.WriteLine("                              |_|   |_|                                    ");
        }

        public void ShowMenu()
        {
            ShowTitle();
            Console.WriteLine("Enter the number of an action into the console to execute that action");
            Console.WriteLine("1. Add stock to list");
            Console.WriteLine("2. Remove Stock");
            Console.WriteLine("3. Print stock");
            Console.WriteLine("4. Exit application");
        }

        public void AddStockProcedure() {
            Console.WriteLine("Type in the name of the stock: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the price per share: ");
            double pricePerShare = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of shares: ");
            int numOfShare = int.Parse(Console.ReadLine());

            _stocks.Add(new Stock(name, pricePerShare, numOfShare));
            Console.WriteLine("Stock added! Press enter to return to menu.");
            Console.ReadLine();

        }

        public void RemoveStockProcedure()
        {
            Console.WriteLine("Remove stock");

            foreach (Stock s in _stocks)
            {
                Console.WriteLine("___________________________________________________");

                Console.WriteLine("Index: {0}", _stocks.IndexOf(s));
                Console.WriteLine(s.ToString());

                Console.WriteLine("___________________________________________________\n");
            }

            Console.WriteLine("Amount of stock in list: {0}", _stocks.Count);

            Console.WriteLine("Type in the index of the stock you would like to remove from the list.");

            int stockIndex = int.Parse(Console.ReadLine());

            try {
                _stocks.RemoveAt(stockIndex);
                Console.WriteLine("Stock removed!");
                Console.WriteLine("Press enter to return to menu.");
                Console.ReadLine();
                
            } catch(Exception e) {
                Console.WriteLine("Index is out of bounds.");

            }

        }

        public void PrintStocks() {

            
            Console.WriteLine("\n Printing the stocks");

            foreach (Stock s in _stocks) {
            Console.WriteLine("___________________________________________________");

            Console.WriteLine("Index: {0}", _stocks.IndexOf(s));
            Console.WriteLine(s.ToString());

            Console.WriteLine("___________________________________________________\n");
            }

            Console.WriteLine("Amount of stock in list: {0}", _stocks.Count);

            Console.WriteLine("Press enter to go back to menu");

            Console.ReadLine();

        }


        public void Run() {
            bool running = true;

            do {
                ShowMenu();
               
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddStockProcedure();
                        break;
                    case "2":
                        RemoveStockProcedure();
                        break;
                    case "3":
                        PrintStocks();
                        break;
                    case "4":
                        running = false;
                        break;



                }
                Console.Clear();
            } while (running);
        }
    }
}
