using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Storyboard.Generators
{
    public class AbstractGenerator
    {
        public virtual void GenerateBackgroundVideoEvents(StringBuilder storyboardCode)
        {
        }

        public virtual void GenerateBackgroundSection(StringBuilder storyboardCode)
        {
        }

        public virtual void GenerateFailSection(StringBuilder storyboardCode)
        {
        }

        public virtual void GeneratePassSection(StringBuilder storyboardCode)
        {
        }

        public virtual void GenerateForegroundSection(StringBuilder storyboardCode)
        {
        }

        public virtual void GenerateSoundSamples(StringBuilder storyboardCode)
        {
        }

    }
}
