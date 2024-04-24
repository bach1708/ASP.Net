using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.PrimeNumbers = GetPrimeNumbers(1, 100);
            ViewBag.Factorials = GetFactorials(1, 10);
            ViewBag.MultiplicationTable = GetMultiplicationTable(2, 9);
            return View();
        }

        private List<int> GetPrimeNumbers(int start, int end)
        {
            List<int> primes = new List<int>();
            for (int num = start; num <= end; num++)
            {
                bool isPrime = true;
                if (num == 1 || num == 0)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    primes.Add(num);
                }
            }
            return primes;
        }

        private List<int> GetFactorials(int start, int end)
        {
            List<int> factorials = new List<int>();
            int factorial = 1;
            for (int i = start; i <= end; i++)
            {
                factorial *= i;
                factorials.Add(factorial);
            }
            return factorials;
        }

        private List<string> GetMultiplicationTable(int start, int end)
        {
            List<string> multiplicationTable = new List<string>();
            for (int i = start; i <= end; i++)
            {
                string row = "";
                for (int j = 1; j <= 10; j++)
                {
                    row += $"{i} x {j} = {i * j}<br/>";
                }
                multiplicationTable.Add(row);
            }
            return multiplicationTable;
        }
    }
}