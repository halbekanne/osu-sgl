using SGL.Library.Classes;
using System;
using System.Collections.Generic;

namespace SGL.Storyboard.Generators.Visual
{
    public class LayerGenerator : AbstractVisualGenerator
    {
        private List<AbstractVisualGenerator> LayerGenerators;

        public LayerGenerator(List<AbstractVisualClass> layerClasses)
        {
            List<AbstractVisualGenerator> LayerGeneratorsTemp = new List<AbstractVisualGenerator>();
            foreach (AbstractVisualClass obj in layerClasses)
            {
                LayerGeneratorsTemp.Add(obj.Object);
            }
            this.LayerGenerators = LayerGeneratorsTemp;
        }

        protected override void GenerateStoryboardCode(System.Text.StringBuilder storyboardCode)
        {
        }

        protected override String GetStoryboardInitCode()
        {
            return null;
        }

        public override void move(int easing, int startTime, int endTime, int startX, int startY, int endX, int endY)
        {
            foreach (AbstractVisualGenerator obj in LayerGenerators)
            {
                obj.move(easing, startTime, endTime, obj.X + startX, obj.Y + startY, obj.X + endX, obj.Y + endY);
            }
        }


        public override void scale(int easing, int startTime, int endTime, double startScale, double endScale)
        {
            foreach (AbstractVisualGenerator obj in LayerGenerators)
            {
                obj.scale(easing, startTime, endTime, obj.Scale * startScale, obj.Scale * endScale);
            }
        }

        public override void fade(int easing, int startTime, int endTime, double startOpacity, double endOpacity)
        {
            foreach (AbstractVisualGenerator obj in LayerGenerators)
            {
                obj.scale(easing, startTime, endTime, obj.Opacity * startOpacity, obj.Opacity * endOpacity);
            }
        }

        public override void color(int easing, int startTime, int endTime, int startRed, int startGreen, int startBlue,
                          int endRed, int endGreen, int endBlue)
        {
            foreach (AbstractVisualGenerator obj in LayerGenerators)
            {
                obj.color(easing, startTime, endTime, Convert.ToInt32(obj.Red * (startRed / 255.0)), Convert.ToInt32(obj.Green * (startGreen / 255.0)), Convert.ToInt32(obj.Blue * (startBlue / 255.0)),
                    Convert.ToInt32(obj.Red * (endRed / 255.0)), Convert.ToInt32(obj.Green * (endGreen / 255.0)), Convert.ToInt32(obj.Blue * (endBlue / 255.0)));
            }
        }

    }
}