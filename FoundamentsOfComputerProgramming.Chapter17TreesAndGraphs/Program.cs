using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundamentsOfComputerProgramming.Chapter17TreesAndGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>(7,
                                        new Tree<int>(19,
                                                             new Tree<int>(1),
                                                             new Tree<int>(12),
                                                             new Tree<int>(31)),
                                        new Tree<int>(21),
                                        new Tree<int>(14, 
                                                            new Tree<int>(23),
                                                            new Tree<int>(6))
                                        );

            
            var treeNodesDFS = tree.TraverseTreeDFS();
            var treeNodesBFS = tree.TraverseTreeBFS();
            Console.WriteLine("DFS:");
            foreach (var item in treeNodesDFS)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("DFS:");
            foreach (var item in treeNodesBFS)
            {
                Console.WriteLine(item);
            }
        }


        
    }
}
