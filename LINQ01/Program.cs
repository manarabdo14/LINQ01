using static LINQ01.ListGenerator;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Nums = new List<int>() { 1, 2, 3, 4, 5,8, 7, 8,9 };

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

            #endregion
        }
    }
}
