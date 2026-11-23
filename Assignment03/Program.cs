using System.Text;

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

            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");

            sb.Replace("Book List", "Library");

            Console.WriteLine(sb);

            #endregion
        }
    }
}
