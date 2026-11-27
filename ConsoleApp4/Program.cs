namespace CSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion



            #region Question 2
            int[,] shelfCopies =
            {
                { 3, 5 },
                { 1, 4 }
            };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion


            #region Question 3
            void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }

            PrintWelcomeMessage();
            #endregion




            #region Question 4
            void PrintBookTitle(string title)
            {
                Console.WriteLine("Book title: " + title);
            }

            PrintBookTitle("Clean Code");
            #endregion



            #region Question 5
            void AddBonusPages(int pages)
            {
                pages = pages + 50;
            }

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine($"After call: pages = {pages}");
            #endregion



            #region Question 6
            void ApplyDiscount(double[] prices)
            {
                prices[0] = prices[0] - 5;
            }

            ApplyDiscount(prices);
            Console.WriteLine($"After call: prices[0] = {prices[0]}");
            #endregion



            #region Question 7
            void AddBonusPagesByRef(ref int pages)
            {
                pages = pages + 50;
            }

            AddBonusPagesByRef(ref pages);
            Console.WriteLine($"After call: pages = {pages}");
            #endregion



            #region Question 8
            void ReplaceArray(ref double[] prices)
            {
                prices = new double[] { 10.0, 12.5, 15.0 };
            }

            ReplaceArray(ref prices);
            Console.WriteLine($"After call: prices.Length = {prices.Length}");
            #endregion


            #region Question 9
            bool TryGetPrice(string title, out double price)
            {
                if (title == "Clean Code")
                {
                    price = 25.5;
                    return true;
                }
                else
                {
                    price = 0;
                    return false;
                }
            }

            double price;
            bool found = TryGetPrice("Clean Code", out price);
            if (found)
                Console.WriteLine($"Price: {price}");
            #endregion


            #region Question 10
            void PrintBookInfo(string title, int pages = 300)
            {
                Console.WriteLine($"Title: {title}, Pages: {pages}");
            }

            PrintBookInfo("Clean Code");
            PrintBookInfo("Clean Code", 450);
            #endregion



            #region Question 11
            PrintBookInfo(pages: 450, title: "Clean Code");
            #endregion



            #region Question 12
            void PrintAllTitles(params string[] titles)
            {
                foreach (string title in titles)
                {
                    Console.WriteLine(title);
                }
            }

            PrintAllTitles("Clean Code", "Refactoring", "Design Patterns");
            #endregion
        }
    }
}