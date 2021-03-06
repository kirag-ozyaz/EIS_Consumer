using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consumer.Classes
{

    public class TreeViewConverter 
    {
        public class Node
        {
            public int val;
            public List<Node> children = new List<Node>();

            // Конструктор по умолчанию
            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, List<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        class Pair
        {
            public Node node;
            public int childrenIndex;
            public Pair(Node _node, int _childrenIndex)
            {
                node = _node;
                childrenIndex = _childrenIndex;
            }
        }


        // Мы будем сохранять начальный индекс как 0, потому что сначала мы всегда
        // обрабатываем большинство левых детей

        int currentRootIndex = 0;
        Stack<Pair> stack = new Stack<Pair>();
        List<int> postorderTraversal = new List<int>();

        // Функция для выполнения итеративного обхода 
        public List<int> postorder(Node root)
        {
            while (root != null || stack.Count != 0)
            {
                if (root != null)
                {
                    // записываем корень и его индекс в стек
                    stack.Push(new Pair(root, currentRootIndex));
                    currentRootIndex = 0;

                    // движемся вниз пока есть дети
                    if (root.children.Count >= 1)
                    {
                        root = root.children[0];
                    }
                    else
                    {
                        // дошли до самого нижнего узла без детей
                        // вся ветка в стеке
                        root = null;
                    }
                    continue;
                }

                Pair temp = stack.Pop();
                // записываем самый нижний узел в список
                postorderTraversal.Add(temp.node.val);

                // извлекаем все элементы из стека пока не кончатся и добавляем их в список
                // выходим из цикла если на этом уровне нет больше соседей 
                while (stack.Count != 0 && temp.childrenIndex == stack.Peek().node.children.Count - 1)
                {
                    temp = stack.Pop();
                    postorderTraversal.Add(temp.node.val);
                }

                // Если стек не пустой, переходим к следующему соседу
                if (stack.Count != 0)
                {
                    root = stack.Peek().node.children[temp.childrenIndex + 1];
                    currentRootIndex = temp.childrenIndex + 1;
                }
            }
            return postorderTraversal;
        }
    }

}
