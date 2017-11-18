using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundamentsOfComputerProgramming.Chapter17TreesAndGraphs
{
    public class TreeNode<T>
    {
        private T value;

        private bool hasParent;

        private List<TreeNode<T>> children;

        public TreeNode(T theValue)
        {
            if (theValue == null)
            {
                throw new ArgumentNullException("Node must have value");
            }

            this.value = theValue;
            this.hasParent = false;
            this.children = new List<TreeNode<T>>();
        }

        public int ChildrenCount => this.children.Count;

        public T Value { get { return this.value; } set { this.value = value; } }

        public bool AddChild(TreeNode<T> node)
        {
            if (node == null || node.hasParent)
            {
                return false;
            }
            this.children.Add(node);     
            return true;
        }


        public TreeNode<T> GetChild(int index)
        {
            if (index >= this.children.Count || index < 0)
            {
                return null;
            }
            return this.children[index];
        }

    }
}
