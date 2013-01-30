using SGL.Library.Classes;
using System;
using System.Collections.Generic;

namespace SGL.Storyboard
{
    public class LayerObject : VisualObject
    {
        private List<VisualObject> layerObjects;

        public LayerObject(List<Visual> layerClasses)
        {
            List<VisualObject> layerObjectsTemp = new List<VisualObject>();
            foreach (Visual obj in layerClasses)
            {
                layerObjectsTemp.Add(obj.Object);
            }
            this.layerObjects = layerObjectsTemp;
        }

        public override void GenerateSbCode(System.Text.StringBuilder storyboardCode)
        {
        }

        protected override String GetStoryboardInitCode()
        {
            return null;
        }

        public override void move(int easing, int startTime, int endTime, int startX, int startY, int endX, int endY)
        {
            foreach (VisualObject obj in layerObjects)
            {
                obj.move(easing, startTime, endTime, obj.X + startX, obj.Y + startY, obj.X + endX, obj.Y + endY);
            }
        }


        public override void scale(int easing, int startTime, int endTime, double startScale, double endScale)
        {
            foreach (VisualObject obj in layerObjects)
            {
                obj.scale(easing, startTime, endTime, obj.Scale * startScale, obj.Scale * endScale);
            }
        }

    }
}