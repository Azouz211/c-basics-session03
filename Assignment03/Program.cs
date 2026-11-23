using System.Text;
using System.Threading.Channels;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 
            //string title = "clean code";
            //string UpperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(UpperTitle);
            #endregion

            #region Question 2

            //string name1 = "Clean Code";
            //string name2 = "Clean Code";
            //bool equal  = ReferenceEquals(name1, name2);
            //Console.WriteLine(equal);


            #endregion

            #region Question 3

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");

            //Console.WriteLine(sb);

            #endregion

            #region Question 4 

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");

            //sb.Replace("Book List", "Library");

            //Console.WriteLine(sb);

            #endregion

            #region Question 5

            //string Title = "Clean Code";
            //int Pages = 464;
            //string Sentence = "Book: " + Title + ", Pages: " + Pages;
            //Console.WriteLine(Sentence);

            #endregion

            #region Question 6

            //string Title = "Clean Code";
            //int Pages = 464;

            //string Sentence = $"Book: {Title}, Pages: {Pages}";
            //Console.WriteLine(Sentence);

            #endregion

            #region Question 7

            //string Title = "Clean Code";
            //int Pages = 464;
            //string Sentence = string.Format("Book: {0} - Pages: {1}", Title, Pages);
            //Console.WriteLine(Sentence);

            #endregion

            #region Question 8

            //int Pages = 300;
            //if ( Pages > 300)

            //    Console.WriteLine("Long Book");
            //else if 
            //    (Pages < 300)
            //    Console.WriteLine("Short Book");
            //else
            //    Console.WriteLine("Book is 300 pages.");




            #endregion

            #region Question 9

            //int Pages = 464;
            //bool IsAvailable = true;
            //if (Pages > 300 && IsAvailable)
            //    Console.WriteLine("Long Book and Available");


            #endregion

            #region Question 10

            //string Title = "Refactoring";
            //switch (Title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;

            #endregion

            #region Question 11 

            int page = 464;
            string SizeLabel = page > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(SizeLabel);
            #endregion


        }
    }
}
