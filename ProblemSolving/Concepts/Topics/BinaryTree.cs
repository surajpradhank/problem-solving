using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Concepts.Topics.BinaryTree;

public class Node
{
    public int data;
    public Node left;
    public Node right;

    public Node(int data)
    {
        this.data = data;
        left = null;
        right = null;
    }
}

public class BinaryTree
{

    public static int index = -1;

    public static void CallBinaryTree()
    {
        int[] node = [1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1];

        Node root = BuildTree(node);

        Console.WriteLine(root.data);
    }

    public static Node BuildTree(int[] nodes)
    {
        index++;

        if (nodes[index] == -1) return null;

        Node newNode = new Node(nodes[index]);
        newNode.left = BuildTree(nodes);
        newNode.right = BuildTree(nodes);

        return newNode;

    }
  
}
