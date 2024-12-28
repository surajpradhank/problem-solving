namespace ProblemSolving.Concepts.Topics;

public class Node
{
    public int data;
    public Node left, right;

    public Node(int val)
    {
        data = val;
        left = null;
        right = null;
    }
}

public class Height_BinaryTree
{
    public static int Height(Node root)
    {
        if (root == null)
            return -1;

        // compute the height of left and right subtrees
        int lHeight = Height(root.left);
        int rHeight = Height(root.right);

        return Math.Max(lHeight, rHeight) + 1;
    }
}
