using LINQ01.Data;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static LINQ01.ListGenerator;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> Nums = new List<int>() { 1, 2, 3, 4, 5,8, 7, 8,9 };
            #region Sassion 01
            #region what is LINQ

            //List<int> OODNums =  Nums.Where(num => num % 2 == 1).ToList();
            //foreach (var item in OODNums)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region LINQ Syntax [fluent , Query]
            ///flunet syntax
            ///satic method
            ///var OODNums = Enumerable.Where(Nums,num => num % 2 == 1);
            ///extenstion method
            /// OODNums = Nums.Where(num => num % 2 == 1);


            ///Query syntax -> like sql
            ///var OODNums = from num in Nums
            ///              where num % 2 == 1
            ///              select num;

            //foreach (var item in OODNums)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Execution ways
            //deferred execution latest version of data
            //var OODNums = Nums.Where(num => num % 2 == 1);
            // Nums.AddRange(new[] { 10, 11, 12, 13, 14, 15, 16 } );
            //foreach (var item in OODNums)
            //{
            //    Console.Write($"{item} "); //1 3 5 7 9 11 13 15
            //}
            //var OODNums = Nums.Where(num => num % 2 == 1).ToList();
            //Nums.AddRange(new[] { 10, 11, 12, 13, 14, 15, 16 });
            //foreach (var item in OODNums)
            //{
            //    Console.Write($"{item} "); //1 3 5 7 9
            //}
            //deferred execution Immdiate

            #endregion

            #region Setup Data
            //Console.WriteLine(ProductsList[0]);
            //Console.WriteLine(CustomersList[0]);
            #endregion

            #region Filtering - Where 
            //OUT OF STOCK 
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0);

            //Result = from p in ProductsList 
            //         where p.UnitsInStock == 0
            //         select p;

            //Meat/Poultry
            //var Result = ProductsList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry");

            //Result = from p in ProductsList 
            //         where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //         select p;

            //Indexed Where  only in fluent syntax 
            //OUT OF STOCK  first 10

            //var Result = ProductsList.Where((p , i) =>  i < 10 && p.UnitsInStock == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Transformation or projection  [select - select many]
            //select product name 
            ////fluent 
            //var Result = ProductsList.Select(p => p.ProductName);
            ////query
            //Result = from p in ProductsList
            //         select p.ProductName;

            ////select customer name 
            //var Result = CustomersList.Select(C => C.CustomerName);
            //Result = from C in CustomersList
            //         select C.CustomerName;


            ////select customer orders 
            //var Result = CustomersList.SelectMany(C => C.Orders);

            //Result = from C in CustomersList 
            //         from O in C.Orders
            //         select O;


            ////select productid , product name 
            //var Result = ProductsList.Select(p => new  { p.ProductID , p.ProductName});

            //Result = from p in ProductsList
            //         select new { p.ProductID, p.ProductName };

            //select products in stock and apply 10% discount
            //var Result = ProductsList.Where(p => p.UnitsInStock > 0)
            //                         .Select(p => new
            //                         {
            //                             ProductID = p.ProductID,
            //                             ProductName = p.ProductName,
            //                             UnitPrice = p.UnitPrice,
            //                             NewPrice = p.UnitPrice - (p.UnitPrice * 0.1M)

            //                         });


            //Result = from p in ProductsList
            //         where p.UnitsInStock > 0
            //         select new
            //         {
            //             ProductID = p.ProductID,
            //             ProductName = p.ProductName,
            //             UnitPrice = p.UnitPrice,
            //             NewPrice = p.UnitPrice - (p.UnitPrice * 0.1M)

            //         };

            //indexed select  only with fluent syntax 
            //var Result = ProductsList.Where(p => p.UnitsInStock > 0)
            //                         .Select((p, i) => new
            //                         {
            //                             Index = i,
            //                             p.ProductName
            //                         });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Ordering Operators 
            //Get products ordering by price ASC
            ////fluent 
            //var Result = ProductsList.OrderBy(p => p.UnitPrice);
            ////Query
            //Result = from p in ProductsList 
            //         orderby p.UnitPrice
            //         select p;

            //Get products ordering by price DESC
            //var Result = ProductsList.OrderByDescending(p => p.UnitPrice);

            //Result = from p in ProductsList
            //         orderby p.UnitPrice descending
            //         select p;

            //Get products ordering by price ASC in and number of unites 
            //var Result = ProductsList.OrderBy(p => p.UnitPrice).ThenByDescending(p => p.UnitsInStock);

            //Result = from p in ProductsList
            //         orderby p.UnitPrice ascending ,p.UnitsInStock descending
            //         select p;


            //REVERSE
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0).Reverse();

            #endregion

            #region Element operator - immediate Execution valid with flunent
            #endregion

            #region Aggregate operators
            #endregion

            #endregion
            #region Sassion 02

            #region  Casting operator  - immediate Execution

            //List<Product> Result = ProductsList.Where(p=>p.UnitsInStock ==0).ToList();

            //Product[] Result = ProductsList.Where(p=>p.UnitsInStock ==0).ToArray();

            //Dictionary<long,Product> Result = ProductsList.Where(p=>p.UnitsInStock ==0).ToDictionary(p => p.ProductID);

            // Dictionary<long,string> Result = ProductsList.Where(p=>p.UnitsInStock ==0).ToDictionary(p => p.ProductID , p=>p.ProductName);

            // HashSet<Product> set = ProductsList.Where(p => p.UnitsInStock == 0).ToHashSet();


            //ArrayList list = new ArrayList()
            //{
            //    "S","Ali",1,"ee",5
            //};

            //var Result = list.OfType<int>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Generation Opertaor - Deffered Excution only with fluent 
            //fluent with static call 
            //var Result = Enumerable.Range(1, 100);

            //Result = Enumerable.Range(1, 100);


            //var list = Enumerable.Empty<Product>().ToList();
            //List<Product> profuctlist = new List<Product>();



            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} " );
            //}
            #endregion

            #region Set operators - Deffered Excution 

            //var Sequ01 = Enumerable.Range(1, 100);
            //var Sequ02 = Enumerable.Range(50, 100);

            ////var Result = Sequ01.Union(Sequ02);
            ////var Result = Sequ01.Concat(Sequ02);

            ////var distinct = Result.Distinct();

            ////var Result = Sequ01.Intersect(Sequ02);
            ////var Result = Sequ01.Except(Sequ02);
            //Console.WriteLine("------------------01----------------");
            //foreach (var item in Sequ01)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n------------------02----------------");

            //foreach (var item in Sequ02)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n------------------Result----------------");
            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region Quantifier operators  return boolean 
            ////Any => If Sequence contains at least one Element Will Return True
            //var Result = ProductsList.Any();

            //Result = ProductsList.Any(p => p.UnitsInStock != 0);

            ////All => If All Elements in Sequence Match Condition Will Return True 
            //Result = ProductsList.All(p => p.UnitsInStock != 0);

            ////SequenceEqual => If Two Sequences are Equal Will Return True 
            //var Sequ01 = Enumerable.Range(1, 100);
            //var Sequ02 = Enumerable.Range(1, 100);

            //Result = Sequ01.SequenceEqual(Sequ02);
            //Console.WriteLine(Result);

            #endregion

            #region Zip operator
            ////ZIP => Produces a sequence with elements from the Two Or Three specific sequences.
            //string[] Names =  { "ali", "soly", "man", "test" };
            //int[] Num =  { 1,2,3,4,5 };
            //char[] chara =  { 'S', 'b' , 'D' , 'r'};

            ////var Result = Names.Zip(Names, chara);
            ////var Result = Names.Zip(chara);
            //var Result = Names.Zip(chara , (name , number) => new
            //{
            //    index= number,
            //    name = name,
            //});


            #endregion

            #region Gruoping operator 
            //Get Products Grouped by Category

            //var Result = from p in ProductsList
            //             group p by p.Category;

            //var Result = ProductsList.GroupBy(p => p.Category);


            //Get Products in Stock Grouped by Category
            //var Result = from p in ProductsList
            //             where p.UnitsInStock > 0
            //             group p by p.Category;

            //var Result = ProductsList.Where(p=> p.UnitsInStock > 0).GroupBy(p => p.Category);


            //Get Products in Stock Grouped by Category That Contains More Than 10 Product
            //var Result = from p in ProductsList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into cat 
            //             where cat.Count() >10
            //             select cat;


            //Result = ProductsList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category).Where(predicate => predicate.Count() > 0);



            //Get Category Name of Products in Stock That Contains More Than 10 Product and Number of Product In Each Category

            //var Result = from p in ProductsList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into cat
            //             where cat.Count() > 10
            //             select  new
            //             {
            //                 count = cat.Count(),
            //                 name = cat.Key
            //             };



            //Result = ProductsList.Where(p => p.UnitsInStock > 0)
            //   .GroupBy(p => p.Category)
            //   .Where(predicate => predicate.Count() > 10)
            //   .Select( X => new
            //   {
            //       count = X.Count(),
            //       name = X.Key
            //   });


            //foreach (var cat in Result)
            //{
            //    Console.WriteLine($"\n {cat.Key} \n");
            //    foreach (var item in cat)
            //    {
            //        Console.WriteLine(item.ProductName);
            //    }
            //    Console.WriteLine("\t");
            //}
            #endregion

            #region Partitioning Operators
            ////Take => Take Number of Elements From First Only 
            //var Result = ProductsList.Take(10);

            ////TakeLast => Take Number of Elements From Last Only
            //Result = ProductsList.TakeLast(10);

            ////Skip => Skip Number of Elements From First And Get Rest Of Elements
            //Result = ProductsList.Skip(10);

            ////SkipLast => Skip Number of Elements From Last And Get Rest Of Elements
            //Result = ProductsList.SkipLast(10);

            //  int[] Nums =
            //  {
            //      1,2,3,8,6,9,10,11,12,13,14,15,16,17
            //  };
            ////  TakeWhile => Take Elements Till Element That do not Match Condition
            //  //var Result = Nums.TakeWhile(N => N < 10);
            //  //Result = Nums.TakeWhile((N , I ) => N > I);


            //  //SkipWhile => Skip Elements Till Element That do not Match Condition
            //  var Result = Nums.SkipWhile(N => N < 10);
            //  Result = Nums.SkipWhile((N, I) => N < I);

            #endregion

            #region Let and Into [Valid With Query Syntax Only]
            string[] Names = { "ali", "soly", "man", "test" };
            //into 
            //var Result = from N in Names
            //             select Regex.Replace(N, "[AOUEIaouei]", string.Empty)
            //             into NoVoules 
            //             where NoVoules.Length > 2
            //             select NoVoules;

            //let
            ////var Result = from N in Names
            ////              let NoVoules = Regex.Replace(N, "[AOUEIaouei]", string.Empty)
            ////              where NoVoules.Length > 2
            ////             select NoVoules;
            #endregion

            #endregion




            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
