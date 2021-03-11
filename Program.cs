using DataStructuresAndAlgorithmsPractices.LinkList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsPractices
{
    public class Program
    {
        static void Main(string[] args)
        {
            NodeLink lnk = new NodeLink();
            lnk.AddFirst("First");
            lnk.AddLast("A");
            lnk.AddLast("B");
            lnk.AddLast("C");
            lnk.AddLast("Last");
            lnk.ReadAll();
            Console.ReadKey();
        }
    }
}
