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
            list.Print();
            list.Delete("3");
            list.Print();            
        }
    }
}