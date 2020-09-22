using System;
using static System.Console;

namespace TreeSearch
{
    public class BinaryTreeSearch
    {
        public void PreOrder(Node node, string value, int depth, ref int attempt)
        {
            if (node == null)
                return;

            if (node != null && node.value == value)
            {
                foundHandler(depth, attempt);
                Environment.Exit(1);
            }
            else
            {
                attempt++;
                PreOrder(node.leftChild, value, depth + 1, ref attempt);
                attempt++;
                PreOrder(node.rightChild, value, depth + 1, ref attempt);
            }

            if (depth == 1)
                foundHandler(0, 0);
        }

        public void PostOrder(Node node, string value, int depth, ref int attempt)
        {
            if (node == null)
                return;

            if (node != null && node.value == value)
            {
                foundHandler(depth, attempt);
                Environment.Exit(1);
            }
            else
            {
                attempt++;
                PostOrder(node.rightChild, value, depth + 1, ref attempt);
                attempt++;
                PostOrder(node.leftChild, value, depth + 1, ref attempt);
            }

            if (depth == 1)
                foundHandler(0, 0);
        }

        public void InOrder(Node node, string value, int depth, ref int attempt)
        {
            if (InOrderHelper(node,value,depth,ref attempt))
                return;

            ++depth;

            ++attempt;
            if (InOrderHelper(node.leftChild, value, depth, ref attempt))
                Environment.Exit(1);

            ++attempt;
            if (InOrderHelper(node.rightChild, value, depth, ref attempt))
                Environment.Exit(1);

            if(node.leftChild != null)
                InOrder(node.leftChild, value, depth, ref attempt);
            if(node.rightChild != null)
                InOrder(node.rightChild, value, depth, ref attempt);
        }

        public bool InOrderHelper(Node node, string value, int depth, ref int attempt)
        {
            if (node != null && node.value == value)
            {
                foundHandler(depth, attempt);
                return true;
            }

            return false;
        }

        public void foundHandler(int depth, int attempt)
        {
            if (depth == 0)
                WriteLine("Not found");
            else
                WriteLine($"Found at depth {depth}, attempt n° {attempt}!");
            ReadKey();
        }
    }
}
