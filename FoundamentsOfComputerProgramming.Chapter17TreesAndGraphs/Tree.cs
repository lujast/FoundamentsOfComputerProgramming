using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundamentsOfComputerProgramming.Chapter17TreesAndGraphs
{
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Root must contain not null value");
            }

            this.root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (var child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public TreeNode<T> Root => this.root;


        public T[] TraverseTreeDFS()
        {
            var nodesValues = new List<T>();

            nodesValues.Add(this.root.Value);

            this.TraverseTreeDFS(this.root, nodesValues);

            return nodesValues.ToArray();
        }



        public T[] TraverseTreeBFS()
        {
            var queue = new Queue<TreeNode<T>>();
            var nodesValues = new List<T>();
            queue.Enqueue(this.root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                nodesValues.Add(node.Value);
                for (int i = 0; i < node.ChildrenCount; i++)
                {
                    var child = node.GetChild(i);
                    queue.Enqueue(child);
                }
            }

            return nodesValues.ToArray();
        }

        private void TraverseTreeDFS(TreeNode<T> node, List<T> nodesValues)
        {

            for (int i = 0; i < node.ChildrenCount; i++)
            {
                nodesValues.Add(node.GetChild(i).Value);
                TraverseTreeDFS(node.GetChild(i), nodesValues);
            }

        }
    }
}
