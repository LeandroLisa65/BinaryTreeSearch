using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSearch
{
    public class BinaryTree
    {
        public Node GetBinaryTree()
        {
            var n1 = new Node(null, null, "1");
            var n3 = new Node(n1, null, "3");
            var n8 = new Node(null, null, "8");
            var n11 = new Node(null, null, "11");
            var n9 = new Node(n8, n11, "9");
            var n7 = new Node(null, n9, "7");
            var n5 = new Node(n3, n7, "5");
            var n12 = new Node(n5, null, "12");
            return n12;
        }
    }
}
