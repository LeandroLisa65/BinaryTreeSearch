using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSearch
{
    public class Node
    {
        public Node(Node leftChild, Node rightChild, string value)
        {
            this.leftChild = leftChild;
            this.rightChild = rightChild;
            this.value = value;
        }

        public Node leftChild { get; set; }
        public Node rightChild { get; set; }
        public string value { get; set; }
    }
}
