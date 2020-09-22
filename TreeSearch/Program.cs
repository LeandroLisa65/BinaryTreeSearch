using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var bt = new BinaryTree().GetBinaryTree();
            var attempt = 1;
            new BinaryTreeSearch().InOrder(bt, "9", 1, ref attempt);
        }
    }
}
