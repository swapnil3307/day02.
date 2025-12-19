using System.Security.Cryptography;

namespace Program01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bklist = new List<Book>
            {
                new Book{Id=1,Title="marathi",Author="vijay",Price=120},
                new Book{Id=2,Title="hindi",Author="ajay",Price=100},
                new Book{Id=3,Title="english",Author="kedar",Price=200},
                new Book{Id=4,Title="tamil",Author="priyanka",Price=250},
                new Book{Id=5,Title="kannada",Author="mahesh",Price=150},
            };

            Console.WriteLine("--- Initial Book List ---");
            foreach (Book bk in bklist)
            {
                bk.Display();
            }

            #region usinglinQ - Original LINQ examples

            // Re-enabled the LINQ OrderBy example (Optional: uncomment to run)
            /*
            var result1 = (from bk in bklist orderby bk.Price ascending select bk);
            Console.WriteLine("\n--- LINQ: Books ordered by Price ascending ---");
            foreach (var item in result1)
            {
                item.Display();
            }
            */

            Console.WriteLine("\n--- LINQ: Books where Author contains 'd' (Authors: kedar) ---");

            // Filter by Author containing 'd'
            var result2 = from bk in bklist where bk.Author.Contains("d") select bk;
            foreach (var item in result2)
            {
                item.Display();
            }

            // --- LINQ Delete Example (Used an ID = 3 for example) ---
            Console.WriteLine("\nEnter ID for delete (e.g., 3):");
            // NOTE: Console.ReadLine() can cause a runtime error if non-integer input is given.
            // Using a TryParse or hardcoded value is safer for demonstration.
            if (!int.TryParse(Console.ReadLine(), out int id1))
            {
                Console.WriteLine("Invalid ID entered. Skipping delete operation.");
            }
            else
            {
                // Find the first book with the matching ID
                Book bookToDeleteLinq = (from bk in bklist where bk.Id == id1 select bk).FirstOrDefault();

                if (bookToDeleteLinq != null)
                {
                    bklist.Remove(bookToDeleteLinq);
                    Console.WriteLine($"Book with ID {id1} was deleted.");
                }
                else
                {
                    Console.WriteLine($"Book with ID {id1} not found.");
                }

                Console.WriteLine("\n--- After LINQ Delete ---");
                foreach (Book bk in bklist)
                {
                    bk.Display();
                }
            }
            #endregion

            // --- 2. Sorting using List<T>.Sort() ---
            // ERROR FIX: Replaced Book.Sort with bklist.Sort and fixed property access (y.Price instead of y.price).
            Console.WriteLine("\n--- All books by descending order of price (using List.Sort) ---");

            // Sort the original list in place
            bklist.Sort((x, y) => y.Price.CompareTo(x.Price));

            foreach (var item in bklist)
            {
                item.Display();
            }

            // --- 3. Filtering using Contains with StringComparison ---
            // ERROR FIX: Replaced variable 'book' with 'bklist' and fixed property access (item.Author instead of item.author).
            Console.WriteLine("\n--- All books where Author name contains letter 'a' (case-insensitive) ---");

            foreach (var item in bklist)
            {
                // Use StringComparison.OrdinalIgnoreCase for case-insensitive check
                if (item.Author.Contains("a", StringComparison.OrdinalIgnoreCase))
                {
                    item.Display();
                }
            }

            // --- 4. Removing a book using List<T>.Find() and List<T>.Remove() ---
            // ERROR FIX: Replaced variable 'books' with 'bklist' and fixed property access (b.Id instead of b.id).
            Console.WriteLine();
            Console.WriteLine("Enter book ID to remove (e.g., 1):");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID entered. Skipping removal operation.");
            }
            else
            {
                // Find the book object based on the ID
                Book bookToRemove = bklist.Find(b => b.Id == id);

                if (bookToRemove != null)
                {
                    bklist.Remove(bookToRemove);
                    Console.WriteLine($"Book with ID {id} removed.");
                }
                else
                {
                    Console.WriteLine($"Book with ID {id} not found.");
                }

                Console.WriteLine("\n--- Final Book List after last removal ---");
                foreach (var item in bklist)
                {
                    item.Display();
                }
            }
        }
    }

    // Book class definition is correct
    class Book
    {
        // Public properties use PascalCase (Id, Title, Author, Price)
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Title: {Title}, Author: {Author}, Price: {Price:C2}");
        }
    }
}