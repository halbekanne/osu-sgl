using SGL.Elements;

namespace SGL.Nodes.Values
{
    internal class BreakNode : AbstractNode
    {
        private readonly int line;

        public BreakNode(int line)
        {
            this.line = line;
        }

        public override int Line
        {
            get { return line; }
        }

        protected override Value Invoke()
        {
            return Value.BREAK;
        }
    }
}