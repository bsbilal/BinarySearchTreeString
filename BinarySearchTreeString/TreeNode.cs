using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeString
{
    public class TreeNode
    {
        
            public string m_Data;
            public TreeNode Left;
            public TreeNode Right;
            public TreeNode()
            {

            }


            public TreeNode(string data)
            {
                this.m_Data = data;
                Left = null;
                Right = null;
            }
        
    }
}
