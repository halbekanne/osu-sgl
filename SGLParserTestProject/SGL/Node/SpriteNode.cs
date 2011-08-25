using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class SpriteNode : SGLNode
    {
        private SGLNode priority;
        private SGLNode filepath;
        private SGLNode layer;
        private SGLNode origin;


        // For testing purpose only, delete after testing
        public SpriteNode()
        {
            this.priority = new AtomNode(0);
            this.filepath = new AtomNode("test");
            this.layer = new AtomNode("Foreground");
            this.origin = new AtomNode("Centre");
        }

        public SpriteNode(SGLNode filepath)
        {
            this.priority = new AtomNode(0);
            this.filepath = filepath;
            this.layer = new AtomNode("Foreground");
            this.origin = new AtomNode("Centre");
        }

        public SGLValue Evaluate()
        {
            SGLValue priorityValue = priority.Evaluate();
            SGLValue filepathValue = filepath.Evaluate();
            SGLValue layerValue = layer.Evaluate();
            SGLValue originValue = origin.Evaluate();

            return new SGLValue(new Sprite(priorityValue, filepathValue, layerValue, originValue));

        }

    }
}
