using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeDemo
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {

        public T NodeData { get; set; }

        public BinarySearchTree<T> LeftTree { get; set; }


        public BinarySearchTree<T> RightTree { get; set; }


        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.RightTree = null;
            this.LeftTree = null;
        }

        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                this.leftCount++;
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                    //this.leftCount++;
                }
                else
                {
                    this.LeftTree.Insert(item);
                   // this.leftCount++;

                }
            }
            else
            {
                this.rightCount++;
                if (this.RightTree == null)
                {
                    this.RightTree = new BinarySearchTree<T>(item);
                    

                }
                else
                {
                    this.RightTree.Insert(item);
                }
            }

        }

        public void Display()
        {
            int left = leftCount;
            int right = rightCount;
            if (this.LeftTree != null)
            {
                left++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());

            if (this.RightTree != null)
            {
                right++;
                this.RightTree.Display();
            }

        }

        public void GetSize()
        {
            Console.WriteLine("Size  " + ( this.leftCount + this.rightCount+1));

        }

        public bool Search(T element, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
              //  Console.WriteLine("Element Found In BST " + node.NodeData);

                result = true;
            }
            else
            {
                Console.WriteLine("Current Element is " + node.NodeData);

            }

            if (element.CompareTo(node.NodeData) < 0)
            {
                Search(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                Search(element, node.RightTree);
            }

            return result;

        }

    }

}