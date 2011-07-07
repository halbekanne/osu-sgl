using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SGL;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compileBtn_Click(object sender, EventArgs e)
        {

            ANTLRStringStream sStream = new ANTLRStringStream(inputBox.Text);
            SGLLexer lexer = new SGLLexer(sStream);

            CommonTokenStream tStream = new CommonTokenStream(lexer);

            SGLParser parser = new SGLParser(tStream);
            
            //try
            //{
                CommonTree t = (CommonTree) parser.compilationUnit().Tree;
                Console.WriteLine("; " + t.ToStringTree());

                CommonTreeNodeStream  treeStream = new CommonTreeNodeStream(t);
                SGLTreeWalker tw = new SGLTreeWalker(treeStream);
                tw.compilationUnit();
/*
            }
            catch (Exception ex)
            {
                outputBox.Text = "Es ist ein Fehler aufgetreten.";
                Console.WriteLine(ex.StackTrace);

            }
            */

            
        }
    }
}
