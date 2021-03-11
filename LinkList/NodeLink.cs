using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsPractices.LinkList
{
    public class NodeLink
    {
        public Node head = null;
        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            //Define head
            if (head == null)
            {
                head = newItem;
                head.next = null;
            }
            else
            {
                //Define next no
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newItem;
                newItem.next = null;
            }
        }
        public void AddFirst(object data)
        {
            //Define head
            Node newItem = new Node();
            newItem.data = data;
            newItem.next = head;
            head = newItem;
        }
        public void ReadAll()
        {
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);

        }
    }
}
