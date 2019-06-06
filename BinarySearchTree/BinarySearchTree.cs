using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public static TreeNode root;
        public static Graphics g;
        public static int RV = 0;
        public static int Head = 0;
        public static int CurrentHeight = 0;
        public static int Iold = -1, Jold = -1,Ihead=-1,Jhead=-1;
        public static bool first = true;
        public static int Lcounter, RCounter;
       
        public static void Insert(ref TreeNode root,int x,int LCount,int ID)        
        {
            if (root == null)
            {
                if (first)                
                {
                    Head = x;
                    first = false;
                }
                root = new TreeNode(x, null, null,LCount,ID);               
            }
            else
            {
                if (x < root.n)
                {
                    root.NBL += 1;
                    Lcounter++;
                    Insert(ref root.left, x,0,Lcounter);                    
                }
                else
                {
                    RCounter++;
                    Insert(ref root.right, x,0,RCounter);                    
                }                                      
            }
           
        }  

        public static void Draw(Panel p, ref TreeNode root,int i)
        {
            Pen pe=new Pen(Color.Red);
            g.DrawEllipse(pe, ((root.NBL * 80) + i), CurrentHeight * 60,30,30);
            if (root.n == Head)
            {
                    Ihead = ((root.NBL * 80) + i); ;
                    Jhead = CurrentHeight * 60;
            }
            if (((root.NBL * 40) + i) + 230 < Iold && Iold!=-1 && Jold!=-1)
            {
                g.DrawLine(pe, Iold+15, Jold + 30, ((root.NBL * 80) + i) + 15, CurrentHeight * 60);
                
            }
            if (((root.NBL * 40) + i) + 230 > Iold && Iold != -1 && Jold != -1)
            {
               g.DrawLine(pe, Iold + 15, Jold + 30, ((root.NBL * 80) + i)+15, CurrentHeight * 60);
            }
            g.DrawString(Convert.ToString(root.n), new Font(FontFamily.GenericSerif, 10, FontStyle.Bold), pe.Brush, (root.NBL * 80) + i + 4, CurrentHeight * 60 + 4, StringFormat.GenericDefault);
            CurrentHeight++;


            if (root.left != null)            
            {
                Iold = ((root.NBL * 80) + i);
                Jold = (CurrentHeight-1) * 60;
                Draw(p, ref root.left, RV);
                CurrentHeight--;
            }
            if (root.right != null)
            {
                if (root.n == Head)
                {
                    RV = (root.NBL + 1) * 80;
                    Iold = Ihead;
                    Jold = Jhead;
                    Draw(p, ref root.right, RV);
                }
                else
                {

                    Iold = ((root.NBL * 80) + i);
                    Jold = (CurrentHeight - 1) * 60;
                    if (root.right.left != null)
                    {
                        int num= root.ID * 80 + RV;
                        Draw(p, ref root.right,num);
                    }
                    else
                    {
                        int num2 = root.ID * 80 + RV;
                        Draw(p, ref root.right, num2);
                    }
                }
                CurrentHeight--;
            }
        }
       
        public static void DeleteNode(ref TreeNode root, ref TreeNode x)
        {
            if (x == null)
                return;
            else
            {
                if (x.right == null)
                    x = x.left;
                else
                    if (x.left == null)
                        x = x.right;
                    else
                    {
                        TreeNode y = x.right;
                        while (y.left != null)
                            y = y.left;

                        y.left = x.left;
                        y = x;// why??
                        x = x.right;
                    }
            }
        }
        public static bool Deletekey(ref TreeNode root, ref TreeNode t, int m)
        {
            if (t == null)
                return false;
            else
            {
                if (t.n == m)
                    DeleteNode(ref root, ref t);
                else
                if (m < t.n)
                    Deletekey(ref root, ref t.left, m);
                else
                    Deletekey(ref root, ref t.right, m);
                return true;
            }
        }
    }    
}
