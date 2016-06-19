namespace LinkedList
{
    public class MainClass
    {
         public static void Main(string[] args)
        {
            var list = new LinkedList();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            System.Console.WriteLine("List's initial contents");
            System.Console.WriteLine(list.GetListContents());
            System.Console.WriteLine("Deleting first element");
            list.Delete("1");
            System.Console.WriteLine(list.GetListContents());
            System.Console.WriteLine("Deleting last element");
            list.Delete("5");
            System.Console.WriteLine(list.GetListContents());
            System.Console.WriteLine("Deleting content from between");
            list.Delete("3");
            System.Console.WriteLine(list.GetListContents());
        }
    }
}