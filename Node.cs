namespace LinkedList
{
    
    public class Node
    {
        public Node Next;
        public object Data;

        public Node(object data, Node node){
            Next = node;
            Data = data;
        }
    }
}