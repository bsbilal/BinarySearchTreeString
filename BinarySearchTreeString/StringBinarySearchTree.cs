using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeString
{
    public class StringBinarySearchTree
    {
        TreeNode Root;
        //will take all of nodes
        private string Nodes;
        public void Add(string NewWord)
        {

            //NodeToAdd's parent
            TreeNode  tempParent = new TreeNode();
            int StringCompare;



            //Start From root and traverse
            TreeNode tempSearch = Root;
            //until tempsearch will be null
            while (tempSearch != null)
            {
                tempParent = tempSearch;
                StringCompare = string.Compare(NewWord, tempSearch.m_Data);
                //string has exist exit
                if (NewWord == tempSearch.m_Data)
                    return;
                else if (StringCompare == -1)
                    tempSearch = tempSearch.Left;
                else
                    tempSearch = tempSearch.Right;
            }
            //create the new Node for add to Tree
            TreeNode NodeToAdd = new TreeNode(NewWord);

            //COMPARE STRING DATA'S
            StringCompare = string.Compare(NewWord, tempParent.m_Data);

            //Tree is empty add to root.

            if (Root == null)
                Root = NodeToAdd;
            else if (StringCompare == -1)
                tempParent.Left = NodeToAdd;
            else
                tempParent.Right = NodeToAdd;
        }

        //Sorted Tree can take with InOrder  
        public void InOrder()
        {
            Nodes = "";
            //send to root for sort
            InOrderString(Root);
        }
        private void InOrderString(TreeNode TraverseNode)
        {
            if (TraverseNode == null)
                return;
            InOrderString(TraverseNode.Left);
            Visit(TraverseNode);
            InOrderString(TraverseNode.Right);
        }
        //take visited node's data
        private void Visit(TreeNode TraverseNode)
        {
            Nodes += TraverseNode.m_Data + " ";
        }
        //will return as sorted
        public string GetNodes()
        {
            return Nodes;
        }
    }
}
