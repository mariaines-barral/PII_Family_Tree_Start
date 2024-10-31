using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        private T element;

        private List<Node<T>> children = new List<Node<T>>();

        public T Number {
            get
            {
                return this.element;
            }
        }

        public ReadOnlyCollection<Node<T>> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T element)
        {
            this.element = element;
        }

        public void AddChildren(Node<T> element)
        {
            this.children.Add(element);
        }
    }
}
