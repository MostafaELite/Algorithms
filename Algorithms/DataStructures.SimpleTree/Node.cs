using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SimpleTree
{
    public class Node<T>
    {
        public T Value { get; set; }

        public IList<Node<T>> Childrens { get; set; }

    }
}
