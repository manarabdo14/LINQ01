using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using static ASS01LinQ.ListGenerator;
using static System.Net.Mime.MediaTypeNames;

namespace ASS01LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 01 LINQ
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.
            //var ProductOutOfStock = ProductsList.Where(p => p.UnitsInStock == 0);
            //Console.WriteLine("products that are out of stock");
            //foreach (var item in ProductOutOfStock)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var ProductInStock = from p in ProductsList
            //                     where p.UnitsInStock > 0 && p.UnitPrice > 3 
            //                     select p;
            //Console.WriteLine("products that are in stock and cost more than 3.00 per unit.");
            //foreach (var item in ProductInStock)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //             .Select((name, index) => new { Digit = index, NameLength = name.Length }) 
            //             .Where(x => x.NameLength < x.Digit) 
            //             .Select(x => x.Digit); 
            //Console.WriteLine("Digits whose name is shorter than their value:");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #endregion

            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 
            //var FirstProductOutOfStock = ProductsList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(FirstProductOutOfStock);
            #endregion

            #region Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var FirstProductk = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(FirstProductk);
            #endregion

            #region  Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumberGreaterThanFive = Arr
            //    .Where(x => x > 5)   
            //    .OrderBy(x => x)     
            //    .Skip(1)             
            //    .FirstOrDefault();   
            //Console.WriteLine("The second number greater than 5 is:");
            //Console.WriteLine(secondNumberGreaterThanFive);
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array
            //    int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int oddCount = Arr.Count(x => x % 2 != 0);

            //Console.WriteLine("The number of odd numbers in the array is:");
            //Console.WriteLine(oddCount);
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //      var customerOrderCounts = from C in  CustomersList 
            //                                select new
            //                                {
            //                                    CustomerName = C.CustomerName,
            //                                    OrderCount = C.Orders.Length
            //                                };
            //foreach (var item in customerOrderCounts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var categoryProductCounts = ProductsList
            //                                      .GroupBy(p => p.Category)
            //                                      .Select(g => new
            //                                      {
            //                                          Category = g.Key,
            //                                          ProductCount = g.Count()
            //                                      });
            //Console.WriteLine("Category and their product counts:");
            //foreach (var item in categoryProductCounts)
            //{
            //    Console.WriteLine($"{item.Category}: {item.ProductCount} products");
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int totalSum = Arr2.Sum();

            //Console.WriteLine("The total sum of the numbers in the array is:");
            //Console.WriteLine(totalSum);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine("Total number of characters: " + totalCharacters);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int shortestWordLength = words.Min(word => word.Length);
            //Console.WriteLine("Length of the shortest word: " + shortestWordLength);
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int longestWordLength = words.Max(word => word.Length);
            //Console.WriteLine("Length of the longest word: " + longestWordLength);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            ////string[] words = File.ReadAllLines("dictionary_english.txt");

            ////double averageLength = words.Average(word => word.Length);

            ////Console.WriteLine("Average length of the words: " + averageLength);
            #endregion

            #region 9. Get the total units in stock for each product category.
            // var totalUnitsInStockByCategory = ProductsList
            //                                 .GroupBy(p => p.Category)
            //                                 .Select(g => new
            //                                 {
            //                                     Category = g.Key,
            //                                     TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //                                 });

            //foreach (var item in totalUnitsInStockByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units in Stock: {item.TotalUnitsInStock}");
            //}
            #endregion

            #region 10. Get the cheapest price among each category's products
            // var cheapestPriceByCategory = ProductsList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    CheapestPrice = g.Min(p => p.UnitPrice)
            //});

            // foreach (var item in cheapestPriceByCategory)
            // {
            //     Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.CheapestPrice:C}");
            // }
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var cheapestProductsByCategory = from p in ProductsList
            //                                 group p by p.Category into g
            //                                 let minPrice = g.Min(x => x.UnitPrice)
            //                                 from p in g
            //                                 where p.UnitPrice == minPrice
            //                                 select new
            //                                 {
            //                                     Category = g.Key,
            //                                     ProductName = p.ProductName,
            //                                     Price = p.UnitPrice
            //                                 };

            //foreach (var item in cheapestProductsByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Product: {item.ProductName}, Price: {item.Price:C}");
            //}
            #endregion

            #region 12. Get the most expensive price among each category's products.
            //        var mostExpensivePerCategory = ProductsList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    MostExpensivePrice = g.Max(p => p.UnitPrice)
            //})
            //.ToList();

            //        foreach (var item in mostExpensivePerCategory)
            //        {
            //            Console.WriteLine($"Category: {item.Category}, Most Expensive Price: {item.MostExpensivePrice}");
            //        }
            #endregion

            #region 13. Get the products with the most expensive price in each category.
            //        var productsWithMaxPrice = ProductsList
            //.GroupBy(p => p.Category)
            //.SelectMany(g =>
            //    g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice))
            //)
            //.ToList();

            //        foreach (var product in productsWithMaxPrice)
            //        {
            //            Console.WriteLine($"Category: {product.Category}, Price: {product.UnitPrice}");
            //        }
            #endregion

            #region 14. Get the average price of each category's products.
            //var averagePricePerCategory = ProductsList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AveragePrice = g.Average(p => p.UnitPrice)
            //    })
            //    .ToList();

            //foreach (var item in averagePricePerCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice:C}");
            //}

            #endregion


            #endregion

            #region LINQ - Ordering Operators


            #region 1. Sort a list of products by name
            //var sortedProducts = ProductsList
            //                                .OrderBy(p => p.ProductName)
            //                                .ToList();

            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Category: {product.Category}, Price: {product.UnitPrice:C}");
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            ////string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ////var sortedArr = Arr
            ////.OrderBy(s => s, StringComparer.OrdinalIgnoreCase)
            ////.ToArray();

            ////foreach (var word in sortedArr)
            ////{
            ////    Console.WriteLine(word);
            ////}

            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var sortedProducts = ProductsList
            //    .OrderByDescending(p => p.UnitsInStock)
            //    .ToList();

            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Units In Stock: {product.UnitsInStock}, Price: {product.UnitPrice:C}");
            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr2 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var sortedArr2 = Arr2
            //                    .OrderBy(s => s.Length)
            //                    .ThenBy(s => s)
            //                    .ToArray();


            //foreach (var word in sortedArr2)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //  string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //  var sortedArr3 = Arr3
            //.OrderBy(s => s.Length) 
            //.ThenBy(s => s, StringComparer.OrdinalIgnoreCase) 
            //.ToArray();

            //  // Output results
            //  foreach (var word in sortedArr3)
            //  {
            //      Console.WriteLine(word);
            //  }
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //          var sortedProducts = ProductsList
            //                                   .OrderBy(p => p.Category) 
            //                                   .ThenByDescending(p => p.UnitPrice) 
            //                                   .ToList();


            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"Category: {product.Category}, Name: {product.ProductName}, Price: {product.UnitPrice:C}");
            //}
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArr4 = Arr4
            //                  .OrderBy(s => s.Length) 
            //                  .ThenByDescending(s => s, StringComparer.OrdinalIgnoreCase)
            //                  .ToArray();

            //foreach (var word in sortedArr4)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr5 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr5
            //         .Where(s => s.Length > 1 && s[1] == 'i') 
            //         .Reverse() 
            //         .ToList();


            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion


            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var productNames = ProductsList
            //        .Select(p => p.ProductName)
            //        .ToList();

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //    string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //    var result = words
            //.Select(word => new
            //{
            //    Original = word,
            //    Uppercase = word.ToUpper(),
            //    Lowercase = word.ToLower()
            //})
            //.ToList();

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"Original: {item.Original}, Uppercase: {item.Uppercase}, Lowercase: {item.Lowercase}");
            //    }
            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //        var result = ProductsList
            //.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Category = p.Category,
            //    Price = p.UnitPrice 
            //})
            //.ToList();

            //        foreach (var item in result)
            //        {
            //            Console.WriteLine($"Name: {item.Name}, Category: {item.Category}, Price: {item.Price:C}");
            //        }
            #endregion

            #region 4. Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr
            //  .Select((value, index) => new
            //  {
            //      Number = value,
            //      InPlace = value == index
            //  })
            //  .ToList();
            //Console.WriteLine($"Number : In-place? ");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($" {item.Number} :  {item.InPlace}");
            //}
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { a, b };

            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //}
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //  var ordersBelow500 = CustomersList
            //.SelectMany(c => c.Orders) 
            //.Where(o => o.Total < 500.00m) 
            //.ToList();

            //  Console.WriteLine("Orders with total less than $500.00:");
            //  foreach (var order in ordersBelow500)
            //  {
            //      Console.WriteLine(order);
            //  }
            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            //     var ordersFrom1998OrLater = CustomersList
            //.SelectMany(c => c.Orders) 
            //.Where(o => o.OrderDate.Year >= 1998)
            //.ToList();

            //     Console.WriteLine("Orders made in 1998 or later:");
            //     foreach (var order in ordersFrom1998OrLater)
            //     {
            //         Console.WriteLine(order);
            //     }
            #endregion

            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List
            //var uniqueCategories = ProductsList
            //          .Select(p => p.Category) 
            //          .Distinct() 
            //          .ToList(); 

            //Console.WriteLine("Unique Categories:");
            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var uniqueFirstLetters = ProductsList
            //                         .Select(p => p.ProductName[0])
            //                         .Concat(CustomersList.Select(c => c.CustomerName[0])) 
            //                         .Distinct() 
            //                         .OrderBy(letter => letter) 
            //                         .ToList();

            //Console.WriteLine("Unique First Letters:");
            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var productFirstLetters = ProductsList
            //                       .Select(p => p.ProductName[0]) 
            //                       .Distinct(); 

            //var customerFirstLetters = CustomersList
            //    .Select(c => c.CustomerName[0]) 
            //    .Distinct(); 

            //var commonFirstLetters = productFirstLetters
            //    .Intersect(customerFirstLetters) 
            //    .OrderBy(letter => letter) 
            //    .ToList(); 

            //Console.WriteLine("Common First Letters:");
            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var productFirstLetters = ProductsList
            //                    .Select(p => p.ProductName[0]) 
            //                    .Distinct(); 

            //var customerFirstLetters = CustomersList
            //    .Select(c => c.CustomerName[0]) 
            //    .Distinct(); 

            //var lettersNotInCustomerNames = productFirstLetters
            //    .Except(customerFirstLetters) 
            //    .OrderBy(letter => letter) 
            //    .ToList(); 

            //Console.WriteLine("Product First Letters Not in Customer Names:");
            //foreach (var letter in lettersNotInCustomerNames)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var productLastThreeChars = ProductsList
            //                      .Select(p => p.ProductName.Length >= 3 ? p.ProductName
            //                      .Substring(p.ProductName.Length - 3) : p.ProductName) 
            //                      .ToList();

            //var customerLastThreeChars = CustomersList
            //    .Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName) 
            //    .ToList();

            //var combinedLastThreeChars = productLastThreeChars
            //    .Concat(customerLastThreeChars) 
            //    .ToList(); 

            //// Output results
            //Console.WriteLine("Last Three Characters from Names:");
            //foreach (var chars in combinedLastThreeChars)
            //{
            //    Console.WriteLine(chars);
            //}
            #endregion

            #endregion



            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington
            //  var firstThreeOrdersInWashington = CustomersList
            //.Where(c => c.Region == "Washington") 
            //.SelectMany(c => c.Orders) 
            //.Take(3) 
            //.ToList(); 

            //  Console.WriteLine("First 3 Orders from Customers in Washington:");
            //  foreach (var order in firstThreeOrdersInWashington)
            //  {
            //      Console.WriteLine($"OrderID: {order.OrderID}, OrderDate: {order.OrderDate.ToShortDateString()}, Total: {order.Total}");
            //  }
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            //var allButFirstTwoOrdersInWashington = CustomersList
            //                                         .Where(c => c.Region == "Washington") 
            //                                         .SelectMany(c => c.Orders) 
            //                                         .Skip(2) 
            //                                         .ToList(); 

            //Console.WriteLine("All but the first 2 Orders from Customers in Washington:");
            //foreach (var order in allButFirstTwoOrdersInWashington)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, OrderDate: {order.OrderDate.ToShortDateString()}, Total: {order.Total}");
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var result = numbers
            //.Select((value, index) => new { value, index })
            //.TakeWhile(x => x.value >= x.index)
            //.Select(x => x.value) 
            //.ToArray();

            // Console.WriteLine("Elements until a number is less than its position:");
            // foreach (var num in result)
            // {
            //     Console.WriteLine(num);
            // }
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var startIndex = Array.FindIndex(numbers2, num => num % 3 == 0);

            //var result = numbers2.Skip(startIndex).ToArray();

            //Console.WriteLine("Elements starting from the first element divisible by 3:");
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var startIndex = numbers3
            //.Select((value, index) => new { value, index })
            //.Where(x => x.value < x.index) 
            //.Select(x => x.index) 
            //.FirstOrDefault(); 

            //if (startIndex == 0 && !numbers3.Any(v => v < Array.IndexOf(numbers3, v)))
            //{
            //    Console.WriteLine("No element is less than its position.");
            //    return;
            //}

            //var result = numbers3.Skip(startIndex).ToArray();

            //Console.WriteLine("Elements starting from the first element less than its position:");
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #endregion



            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //bool containsEi = words.Any(word => word.Contains("ei", StringComparison.OrdinalIgnoreCase));

            //if (containsEi)
            //{
            //    Console.WriteLine("There are words containing the substring 'ei'.");
            //}
            //else
            //{
            //    Console.WriteLine("No words contain the substring 'ei'.");
            //}
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            // var categoriesWithOutOfStock = ProductsList
            //.Where(p => p.UnitsInStock == 0) 
            //.Select(p => p.Category) 
            //.Distinct() 
            //.ToList(); 

            // var groupedProducts = ProductsList
            //     .Where(p => categoriesWithOutOfStock.Contains(p.Category)) 
            //     .GroupBy(p => p.Category) 
            //     .ToList(); 

            // Console.WriteLine("Grouped Products for Categories with Out-of-Stock Items:");
            // foreach (var group in groupedProducts)
            // {
            //     Console.WriteLine($"Category: {group.Key}");
            //     foreach (var product in group)
            //     {
            //         Console.WriteLine($"  Product Name: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //     }
            // }
            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var categoriesWithAllInStock = ProductsList
            //                        .GroupBy(p => p.Category) 
            //                        .Where(g => g.All(p => p.UnitsInStock > 0)) 
            //                        .Select(g => g.Key) 
            //                        .ToList(); 

            //var groupedProducts = ProductsList
            //    .Where(p => categoriesWithAllInStock.Contains(p.Category))
            //    .GroupBy(p => p.Category) 
            //    .ToList(); 

            //// Output the results
            //Console.WriteLine("Grouped Products for Categories with All Products In Stock:");
            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"  Product Name: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //    }
            //}
            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> Numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var groupedByRemainder = Numbers
            //            .GroupBy(n => n % 5)
            //            .OrderBy(g => g.Key); 

            //Console.WriteLine("Numbers partitioned by their remainder when divided by 5:");
            //foreach (var group in groupedByRemainder)
            //{
            //    Console.WriteLine($"Remainder {group.Key}:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine($"  {number}");
            //    }
            //}
            #endregion

            #region Uses group by to partition a list of words by their first letter.  Use dictionary_english.txt for Input
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var groupedWords = words
            //    .GroupBy(word => word[0])
            //    .OrderBy(group => group.Key); 

            //foreach (var group in groupedWords)
            //{
            //    Console.WriteLine($"Words starting with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine(); 
            //}
            #endregion

            #region Consider this Array as an Input , Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            string[] Arr = { "from", "salt", "earn", " last", "near", "form" };


            var groupedWords = Arr
    .GroupBy(word => word, new AnagramComparer()) // Use the custom comparer
    .ToList(); // Convert to list for easy iteration

            // Output the results
            Console.WriteLine("Words grouped by anagrams:");
            foreach (var group in groupedWords)
            {
                Console.WriteLine($"Group:");
                foreach (var word in group)
                {
                    Console.WriteLine($"  {word}");
                }
            }

            #endregion
            #endregion


        }
    }

    public class AnagramComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return GetSortedChars(x) == GetSortedChars(y);
        }

        public int GetHashCode(string obj)
        {
            return GetSortedChars(obj).GetHashCode();
        }

        private string GetSortedChars(string str)
        {
            // Convert the string to lowercase, sort its characters, and return as a new string
            var sortedChars = str.ToLower().OrderBy(c => c);
            return new string(sortedChars.ToArray());
        }
    }
    }
