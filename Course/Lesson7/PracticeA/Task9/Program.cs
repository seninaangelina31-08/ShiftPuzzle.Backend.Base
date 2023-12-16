namespace Task9;

class Program
{
    public T Data { get; set; }
    public List<TreeNode<T>> Children { get; } = new List<TreeNode<T>>();

    public TreeNode(T data) => Data = data;

    public TreeNode<T> DeepCopy() => new TreeNode<T>(Data) { Children = Children.ConvertAll(child => child.DeepCopy()) };
}

class TreeDeepCopyExample
{
    static void Main()
    {
        var rootNode = new TreeNode<int>(1);
        rootNode.Children.AddRange(new[] { new TreeNode<int>(2), new TreeNode<int>(3) });

        var copiedTree = rootNode.DeepCopy();

        rootNode.Children[0].Data = 10;

        Console.WriteLine("Copied Tree Data:");
        PrintTreeData(copiedTree);
    }

    static void PrintTreeData(TreeNode<int> node)
    {
        Console.WriteLine(node.Data);
        node.Children.ForEach(PrintTreeData);
    }
}