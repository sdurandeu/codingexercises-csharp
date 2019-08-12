// Write a method to check that a binary tree is a valid binary search tree.
public class BinaryTreeNode
{
	public int Value { get; }

	public BinaryTreeNode Left { get; set; }

	public BinaryTreeNode Right { get; set; }

	public BinaryTreeNode(int value)
	{
		Value = value;
	}
}

public class BinaryTree
{
	public BinaryTreeNode root;

}

class Program
{
	static bool ValidateBinaryTree(BinaryTreeNode node, int lowerBound, int upperBound)
	{
		if (node == null)
		{
			return true;
		}

		if (node.Value > upperBound || node.Value < lowerBound)
		{
			return false;
		}

		bool validLeft = ValidateBinaryTree(node.Left, lowerBound, node.Value);

		Console.WriteLine(node.Value);

		bool validRight = ValidateBinaryTree(node.Right, node.Value, upperBound);

		return validLeft && validRight;
	}

	static void Main(string[] args)
	{
		BinaryTree tree = new BinaryTree();
		tree.root = new BinaryTreeNode(50);
		tree.root.Left = new BinaryTreeNode(30);
		tree.root.Right = new BinaryTreeNode(80);
		tree.root.Left.Left = new BinaryTreeNode(20);
		tree.root.Left.Right = new BinaryTreeNode(35);
		tree.root.Right.Left = new BinaryTreeNode(70);
		tree.root.Right.Right = new BinaryTreeNode(90);

		var ret = ValidateBinaryTree(tree.root, int.MinValue, int.MaxValue);

		Console.WriteLine(ret);
	}