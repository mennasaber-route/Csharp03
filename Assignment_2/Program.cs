using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region Question6
            ////Declare a double price = 49.99; then convert it into an int using a cast.


            //double price = 49.99;
            //int intPrice = (int)price;
            //Console.WriteLine(intPrice);

            #endregion



            #region Question7
            ////Given string pagesText = "464";, convert it into an int using the Convert class


            //string pagesText = "464";
            //int intPages = Convert.ToInt32(pagesText);
            //Console.WriteLine(intPages);

            #endregion



            #region Question8
            ////Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";
            ////,use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.



            //string yearText = "2023";
            //int years = int.Parse(yearText);
            //Console.WriteLine(years);

            //string badText = "abc";
            //bool isParsed = int.TryParse(badText, out int number);
            //if ( !isParsed )
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion


            #region Question9
            ////Given int pages = 464;, convert it into a string using ToString()
            ////and print its type using GetType() to prove it's now a string.


            //int pages = 464;
            //string pagesString = pages.ToString();
            //Console.WriteLine(pagesString);
            //Console.WriteLine(pagesString.GetType()); 

            #endregion



            #region Question10
            ////Declare int copies = 100;. Box it into an object variable,
            ////then unbox it back into a new int variable, and print both.


            //int copies = 100;
            //object objcopies = copies;
            //Console.WriteLine(objcopies);

            //int newCopies = (int)objcopies;
            //Console.WriteLine(newCopies);


            #endregion


            #region Question11
            ////Given int pages = 464;, write an if / else statement that prints "Long Book"
            ////if pages is greater than 300, otherwise prints "Short Book".


            //int pages = 464;
            //if(pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}

            #endregion



            #region Question12
            ////Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book"
            ////only if pages is greater than 300 and isAvailable is true. Use the && operator


            //int pages = 464;
            //bool isAvailable = true;

            //if(pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}


            #endregion
        }
    }
}
