using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SGLTest
{
    public partial class SGLEditor : Form
    {
        public SGLEditor()
        {
            InitializeComponent();
            SetSyntaxHighlighting();
            PopulateTreeView();
        }

        private void SetSyntaxHighlighting()
        {
            syntaxSGL.SyntaxFile = Application.StartupPath + @"\SGL.syn";
            //Console.WriteLine("Path: " + Application.StartupPath + @"\SGL.syn");
            SGLBox.ShowScopeIndicator = true;
            syntaxStoryboard.SyntaxFile = Application.StartupPath + @"\OSB.syn";

            //

        }

        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"E:\Program Files (x86)\osu!\Songs");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                showImages(info);
                //GetDirectories(info.GetDirectories(), rootNode);
                //treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void showImages(DirectoryInfo dir)
        {
            //this.imageList1.ImageSize = new Size(32, 32);

            //DirectoryInfo dir = new DirectoryInfo(nodeDirInfo);

            ListViewItem item = new ListViewItem("\\.. (Parent Directory)", 0);
            item.Tag = dir.Parent;
            this.listView1.Items.Add(item);

            foreach (DirectoryInfo subdir in dir.GetDirectories())
            {
                item = new ListViewItem(subdir.Name, 0);
                item.Tag = subdir;
                this.listView1.Items.Add(item);
            }

            int j = 1;
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    this.imageList1.Images.Add(Image.FromFile(file.FullName));
                    item = new ListViewItem();
                    item.ImageIndex = j;
                    item.Text = file.Name;
                    item.Tag = file;
                    this.listView1.Items.Add(item);
                    j++;
                }
                catch
                {
                    // do nothing
                }
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //this.listView1.View = View.LargeIcon;
            //this.listView1.LargeImageList = this.imageList1;
            //or
            //this.listView1.View = View.SmallIcon;
            //this.listView1.SmallImageList = this.imageList1;

            //for (int j = 0; j < this.imageList1.Images.Count; j++)
            //{
                

                /*ListViewItem.ListViewSubItem[] subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"), 
                     new ListViewItem.ListViewSubItem(item, 
						"blaaaa")};

                item.SubItems.AddRange(subItems);*/

                
            //}

            

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SGLEditor_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems[0].Tag != null)
            {
                if (listView1.SelectedItems[0].Tag is DirectoryInfo)
                {
                    for (int j = 1; j < this.imageList1.Images.Count; j++)
                    {
                        imageList1.Images.RemoveAt(j);
                    }
                    DirectoryInfo clickedFile = (DirectoryInfo)listView1.SelectedItems[0].Tag;
                    listView1.Items.Clear();
                    showImages(clickedFile);
                }
                else if (listView1.SelectedItems[0].Tag is FileInfo)
                {
                    FileInfo file = (FileInfo)listView1.SelectedItems[0].Tag;
                    //SGLBox.Paste
                    String oldClip = System.Windows.Forms.Clipboard.GetText();
                    System.Windows.Forms.Clipboard.SetText("var " + file.Name.Substring(0, file.Name.Length - 4) + " = new Sprite(\"" + file.Name + "\");" + "\r\n");
                    SGLBox.Paste();
                    System.Windows.Forms.Clipboard.SetText(oldClip);
                    //SGLBox.Document.Text += ;
                }

            }
            
        }


        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem item = listView1.Items[i];
                if (item.Text.Contains(textBox1.Text))
                {
                    //item.
                }
                else
                {

                }
            }
        }



        
    }
}
