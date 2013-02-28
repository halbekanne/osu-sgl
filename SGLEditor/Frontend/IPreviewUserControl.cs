using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SGLTest
{
    public interface IPreviewUserControl
    {
        void Add(IItem anItem);
        void Remove(IItem anItem);
        void ClearItems();
    }

    public class PreviewUserControl : FlowLayoutPanel, IPreviewUserControl
    {
        public PreviewUserControl()
        {
            items = new List<IItem>();
        }

        IList<IItem> items;

        // add an item to items 
        public void Add(IItem anItem)
        {
            items.Add(anItem);
            AddControl(anItem);
        }

        // remove an item from items 
        public void Remove(IItem anItem)
        {
            items.Remove(anItem);
            RemoveControl(anItem);
        }

        //add preview picture box
        private void AddControl(IItem anItem)
        {
            this.Controls.Add(new PreviewPictureBox(anItem));
        }

        //remove preview picture box
        private void RemoveControl(IItem anItem)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is PreviewPictureBox)
                {
                    if ((this.Controls[i] as PreviewPictureBox).PreviewItem.Id == anItem.Id)
                    {
                        this.Controls.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        // Clear list
        public void ClearItems()
        {
            items.Clear();
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is PreviewPictureBox)
                {
                    this.Controls.RemoveAt(i);
                }
            }
        }
    }

    class PreviewPictureBox : PictureBox
    {
        public PreviewPictureBox(IItem anItem)
        {
            previewItem = anItem;
            base.SizeMode = PictureBoxSizeMode.Zoom;
            this.Width = 100; //default width
            this.Height = 60; // default width;
            this.Click += new EventHandler(PreviewPictureBox_Click);
        }

        void PreviewPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PreviewItem.Filename);
        }

        IItem previewItem;

        public IItem PreviewItem
        {
            get { return previewItem; }
        }

        Image image;
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (image == null)
            {
                switch (PreviewItem.ItemType)
                {
                    case EItemType.Default:
                        image = Image.FromFile(@"c:\default.png");
                        break;
                    case EItemType.Picture:
                        image = Image.FromFile(PreviewItem.Filename);
                        break;
                }
                this.Image = image;
            }

        }
    }
}
