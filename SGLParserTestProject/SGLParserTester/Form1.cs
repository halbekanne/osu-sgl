using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SGL;
using SGL.AntlrParser;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.Diagnostics;

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

            try
            {
                Stopwatch otherTime = new Stopwatch();
                otherTime.Start();
                ANTLRStringStream sStream = new ANTLRStringStream(inputBox.Text);
                SGLLexer lexer = new SGLLexer(sStream);

                CommonTokenStream tStream = new CommonTokenStream(lexer);
                
                // Parsing
                Stopwatch parseTime = new Stopwatch();
                parseTime.Start();
                SGLParser parser = new SGLParser(tStream);
                CommonTree t = (CommonTree)parser.compilationUnit().Tree;
                parseTime.Stop();
                
                // Printing tree
                Console.WriteLine("; " + t.ToStringTree());

                // TreeWalking
                CommonTreeNodeStream treeStream = new CommonTreeNodeStream(t);

                Stopwatch walkingTime = new Stopwatch();
                walkingTime.Start();
                SGLTreeWalker tw = new SGLTreeWalker(treeStream);
                SGLNode returned = tw.compilationUnit();
                returned.Evaluate();
                walkingTime.Stop();
                otherTime.Stop();

                Console.WriteLine("Time needed for parsing: " + parseTime.ElapsedMilliseconds + " ms (" + parseTime.Elapsed + ")");
                Console.WriteLine("Time needed for tree walking: " + walkingTime.ElapsedMilliseconds + " ms (" + walkingTime.Elapsed + ")");
                Console.WriteLine("Time needed for anything else (convertion etc.): " + (otherTime.ElapsedMilliseconds - parseTime.ElapsedMilliseconds - walkingTime.ElapsedMilliseconds) + " ms (" + (otherTime.Elapsed - parseTime.Elapsed - walkingTime.Elapsed) + ")");

            }
            catch (Exception ex)
            {
                outputBox.Text = "Es ist ein Fehler aufgetreten.";
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }
            

            
        }
    }
}
