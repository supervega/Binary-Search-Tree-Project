using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinarySearchTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            BinarySearchTree.g = panel1.CreateGraphics();
            BinarySearchTree.g.Clear(Color.White);
            BinarySearchTree.RV = 0;
            BinarySearchTree.Iold = -1;
            BinarySearchTree.Jold = -1;
            BinarySearchTree.CurrentHeight = 0;
            BinarySearchTree.Lcounter = 0;
            BinarySearchTree.RCounter = 0;
            BinarySearchTree.Insert(ref BinarySearchTree.root, Convert.ToInt32(ADDTextBox.Text), 0, 0);
            BinarySearchTree.Draw(panel1, ref BinarySearchTree.root,0);
        }

        private void ADDTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Addbtn_Click(sender, e);
        }

        
    }
}
