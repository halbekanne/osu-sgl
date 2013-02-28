using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SGLTest
{
    public interface IItem
    {
        Guid Id
        {
            get;
        }

        string Filename
        {
            get;
            set;
        }

        EItemType ItemType
        {
            get;
            set;
        }

        void RefreshType();
    }

    public enum EItemType
    {
        Default,
        Picture
    }

    public class Item : IItem
    {
        public Item()
        {
            id = Guid.NewGuid();
        }

        Guid id;

        public Guid Id
        {
            get { return id; }
        }

        string filename;

        public string Filename
        {
            get { return filename; }
            set
            {
                filename = value;
                RefreshType();
            }
        }

        EItemType itemType;

        public EItemType ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }

        public void RefreshType()
        {
            FileInfo info = new FileInfo(Filename);
            ItemType = ItemTypeFactory.GetItemType(info.Extension);
        }


    }

    class ItemTypeFactory
    {
        static string[] pictures = { ".png", ".bmp", ".jpg", ".gif" };
        public static EItemType GetItemType(string aFileExtension)
        {
            EItemType result = EItemType.Default;
            List<string> pictureList = new List<string>();
            pictureList.AddRange(pictures);

            if (pictureList.Contains(aFileExtension))
            {
                result = EItemType.Picture;
            }

            return result;
        }
    }
}
