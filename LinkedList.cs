using System;

namespace LinkedList
{
    class Node
    {
        public Node Next;
        public object Data;

        public Node(object data, Node node){
            Next = node;
            Data = data;
        }
    }
    
    public class LinkedList
    {
        Node head;

        public LinkedList(){
            head = new Node("start", null);
        }

        public void Add(object data){
            Node reader = head;
            while (reader?.Next != null)
            {
                reader = reader.Next;
            }
            
            reader.Next = new Node(data, null);
        }

        public void Print(){
            Node node = head.Next;
            while (node != null)
            {
                Console.WriteLine(node.Data + "\n");
                node = node.Next;
            }
        }
    }
}