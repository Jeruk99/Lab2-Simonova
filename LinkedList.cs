using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonomarevLab2
{
    public class SingleLinkedList
    {
        Node first;
        
        public int First
        {
            get { return first.Info; }
        }
        public SingleLinkedList()
        {
            first = null;
        }

        
        public SingleLinkedList(int data)
        {
            Node p = new Node(data);
            first = p;
        }
        public SingleLinkedList(int[] data)
        {
            first = null;
            for (int i = data.Length - 1; i >= 0; i--)
            {
                Node p = new Node(data[i]);
                if (first == null)
                {
                    first = p;
                }
                else
                {
                    p.Link = first;
                    first = p;
                }
            }
        }
        public int Length {get {
                Node p = first;
                int count = 0;
                while (p != null)
                {
                    count += 1;
                    p = p.Link;
                }
                return count;
            }
        }
        public int this[int n]
        {
            get
            {
                if (n < 0 || n >= Length)
                    throw new IndexOutOfRangeException("Элемента с указанным индексом не существует");
                else
                {
                    Node currentNode = first;
                    int i = 0;
                    while (i < n)
                    {
                        currentNode = currentNode.Link;
                        i++;
                    }
                    return currentNode.Info;
                }
            }
            set
            {
                if (n < 0 || n >= Length)
                    throw new IndexOutOfRangeException("Элемента с указанным индексом не существует");
                else
                {
                    Node currentNode = first;
                    int i = 0;
                    while (i < n)
                    {
                        currentNode = currentNode.Link;
                        i++;
                    }
                    currentNode.Info = value;
                }
            }
        }
        public void InsertBeforeFirst(int data)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
            }
            else
            {
                p.Link = first;
                first = p;
            }
        }
        public void InsertAfterLast(int data)
        {
            Node q = new Node(data);
            Node p = first;
            if (first != null)
            {
                while (p.Link != null)
                    p = p.Link;
                p.Link = q;

            }
            else first = q;
        }
        public void Insert(int ind, int value)
        {
            if (ind < 0 || (ind >= Length && Length != 0))
                throw new IndexOutOfRangeException("Индекс выходит за границы списка");
            else
            {
                Node newNode = new Node();
                Node previousNode = null;
                Node currentNode = first;
                newNode.Info = value;
                if (ind == 0)
                    InsertBeforeFirst(value);
                else
                {
                    int i = 0;
                    while (i < ind)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.Link;
                        i++;
                    }
                    previousNode.Link = newNode;
                    newNode.Link = currentNode;
                }
            }
        }
            public void RemoveAt(int ind)
            {
                if (ind < 0 || ind >= Length)
                    throw new IndexOutOfRangeException("Индекс выходит за границы");
                else if (first == null)
                    throw new NullReferenceException("Список пуст, удалять нечего");
                else
                {
                    Node previousNode = null;
                    Node currentNode = first;
                    if (ind == Length - 1)
                        DeleteLast();
                    else if (ind == 0)
                        DeleteFirst();
                    else
                    {
                        for (int i = 0;i<ind;i++)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.Link;
                    }
                        previousNode.Link = currentNode.Link;
                    }

                }

            }
        public Node DeleteAfter(Node p)
        {
            Node q = null;
            if (p != null && p.Link != null)
            {
                q = p.Link;
                p.Link = q.Link;
            }
            return q;
        }
        public void DeleteList()
        {
            first = null;
        }

        public Node FindNode(int data)
        {
            Node p = first;
            while ((p != null) && (p.Info != data))
            {
                p = p.Link;
            }
            return p;
        }
        
        public void DeleteFirst()
        {
            if (first != null)
                first = first.Link;
        }
        public void DeleteLast()
        {
            Node curNode = first;
            while (curNode.Link.Link != null)
                curNode = curNode.Link;
            curNode.Link = null;
        }
        public override string ToString()
        {
            string res = "";
            Node p = first;
            while (p != null)
            {
                res  +=  p.Info + " ";
                p = p.Link;
            }
            return res;
        }
    }
}
