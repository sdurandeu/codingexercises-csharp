Iterate over a singly linked list backwards. Call print on each node. 
Example: The list A->B->C should print as 
"C B A"
class Node {
  public Node next;
  public String value;
}
There are 4 solutions 
1) recursive 
2) iterative with O(n) memory 
3) iterative with O(1) memory and O(n²) runtime 
4) iterative with O(1) memory and O(n) runtime (for this solution the initial list may be modified) 
Explain all 4 solutions and write the code for solutions 3 and 4


# Solution 3
namespace ConsoleApp4
{
    class Program
    {
        class Node
        {
            public string text;

            public Node next = null;

            public Node(string str)
            {
                text = str;
            }
        }

		// SOLUTION 3 (O(n^2))
        static void TraverseBackwards(Node root)
        {
            int depth = 0;
            // find the depth of the list
            var node = root;
            do
            {
                depth++;
                node = node.next;
            }
            while (node != null);

            // print from the depth backwards
            while (depth > 0)
            {
                node = root;
                var pointer = 1;
                while (pointer <= depth)
                {
                    if (pointer == depth)
                    {
                        depth--;
                        Console.WriteLine(node.text);
                    }
                    pointer++;
                    node = node.next;
                };
            }
        }

		// SOLUTION 4 (Modify the List)
        static void TraverseBackwards(Node root)
        {
            var prev = root;
            var node = root.next;
            do
            {
                var temp = node.next;
                node.next = prev;
                prev = node;
                node = temp;
            }
            while (node != null);

            root.next = null;
            PrintList(prev);
        }
		
        static void Main(string[] args)
        {
            Node root = new Node("1");
            Node a = new Node("2");
            Node b = new Node("3");
            Node c = new Node("4");

            root.next = a;
            a.next = b;
            b.next = c;

            TraverseBackwards(root);
        }
    }
}
