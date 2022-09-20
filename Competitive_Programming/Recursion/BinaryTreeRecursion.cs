using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Recursion
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class BinaryTreeRecursion
    {
        public static bool CheckTree(TreeNode root)
        {
            if (root.left == null)
                return true;

            if (root.val == (root.left?.val + root.right?.val))
                return CheckTree(root.left);
            else
                return false;


        }
    }
}
