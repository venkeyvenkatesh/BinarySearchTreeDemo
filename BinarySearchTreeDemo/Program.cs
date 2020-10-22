using System;

namespace BinarySearchTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Implimentation!");

            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(16);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);
          //  binarySearchTree.Insert(16);

            binarySearchTree.Display();

            binarySearchTree.GetSize();

            if(binarySearchTree.Search(11, binarySearchTree))
            {
                Console.WriteLine("11 is found in BST");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

          

        }
    }
}