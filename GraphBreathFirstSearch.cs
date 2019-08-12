// Find minium path between two nodes
// this algorithm support cycles
public static void BreathFirstSearch(Dictionary<int, int[]> graph, int startNode, int endNode)
{
    // validate input
    if (graph.Count == 0 || !graph.ContainsKey(startNode) || !graph.ContainsKey(endNode)) { return; }

    // initialize variables
    var comingFrom = new Dictionary<int, int>();
    var visited = new HashSet<int>();
    var queue = new Queue<int>();
    var pathFound = false;

    queue.Enqueue(startNode);
    comingFrom.Add(startNode, -1);
    while (queue.Count > 0)
    {
        var nodeKey = queue.Dequeue();

        if (nodeKey == endNode)
        {
            pathFound = true;
            break;
        };

        foreach (var adyacent in graph[nodeKey])
        {
            if (!visited.Contains(adyacent))
            {
                visited.Add(adyacent);
                queue.Enqueue(adyacent);

                // save to backtrack path
                if (!comingFrom.ContainsKey(adyacent))
                {
                    comingFrom.Add(adyacent, nodeKey);
                }
            }
        }
    }

    // output path
    var index = endNode;
    while (index != -1 && pathFound)
    {
        Console.WriteLine(index);
        index = comingFrom[index];
    }
}

static void Main(string[] args)
{
	var graph = new Dictionary<int, int[]>()
	{
		{ 0, new int[] { 1, 5 } },
		{ 1, new int[] { 0, 2, 3 } },
		{ 2, new int[] { 1, 3 } },
		{ 3, new int[] { 1, 2, 4 } },
		{ 4, new int[] { 3, 1 } },
		{ 5, new int[] {  } }
	};

	BreathFirstSearch(graph, 4, 0);
}