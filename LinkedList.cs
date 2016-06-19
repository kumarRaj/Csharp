using System;
using System.Text;

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

        public void Delete(object data){
            Node current = head.Next;
            Node previous = head;
            while (current != null)
            {
                if(current.Data.Equals(data)){
                    previous.Next = current.Next;
                }
                previous = current;
                current = current.Next;
            }            
        }

        public string GetListContents(){
            StringBuilder builder = new StringBuilder("");
            Node node = head.Next;
            while (node != null)
            {
                builder.Append(node.Data + "\t");
                node = node.Next;
            }
            builder.Append("\n");
            return builder.ToString();
        }
    }
}