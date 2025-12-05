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


/*
    
    Let’s start at Height(root) where root = node 1:

    1. Height(1)
       Height(2) → go to left

    2. Height(2)
       Height(4) → go to left again

    3. Height(4)
       Height(null) → returns -1 (left)
       Height(null) → returns -1 (right)
       Returns Math.Max(-1, -1) + 1 = 0

    🔁 Back to Height(2), now right side:

    4. Height(5)
       Height(null) → returns -1
       Height(null) → returns -1
       Returns 0

    🔁 Back to Height(2):
       lHeight = 0, rHeight = 0
       Returns Math.Max(0, 0) + 1 = 1

    🔁 Back to Height(1), now right side:

    5. Height(3)
       Height(null) → returns -1
       Height(null) → returns -1
       Returns 0

    🔁 Final return from Height(1):
       lHeight = 1, rHeight = 0
       Returns Math.Max(1, 0) + 1 = 2

 */
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
