using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Storyboard;

namespace SGL.Elements
{

    /// <summary>
    /// Singleton containing methods which can be used in SGL
    /// </summary>
    class GlobalMemory
    {
        private static readonly GlobalMemory instance = new GlobalMemory();

        private GlobalMemory() { }

        public static GlobalMemory Instance
        {
            get
            {
                return instance;
            }
        }


        private Random random = new Random();
        private List<VisualObject> storyboardObjects = new List<VisualObject>();

        public void RegisterVisualObject(VisualObject vo)
        {
            storyboardObjects.Add(vo);
        }

        public Random Random
        {
            get
            {
                return random;
            }
        }

    }
}
