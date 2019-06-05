using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleID3
{
    public sealed class DecisionTreeNode<T>
    {
        public int Label { get; set; }
        public T Value { get; set; }
        public List<DecisionTreeNode<T>> Children { get; set; }
        public DecisionTreeNode(int label, T value)
        {
            Label = label;
            Value = value;
            Children = new List<DecisionTreeNode<T>>();
        }
    }
}
