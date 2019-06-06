using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    public class TreeNode
    {
        public int n;
        public int NBL;
        public int ID;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int n, TreeNode left, TreeNode right,int NBL,int ID)
        {
            this.n = n;
            this.NBL = NBL;
            this.ID = ID;
            this.left = left;
            this.right = right;
        }
    }
}
