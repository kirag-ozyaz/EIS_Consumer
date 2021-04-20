using System.Collections.Generic;


    namespace Consumer.Classes
    {
        /// <summary>
        /// Warning!!!
        /// This class is needed only for demonstration of features of FastTree.
        /// In real life you need to use own class of your data model.
        /// </summary>
        public class Node : IEnumerable<Node>
        {
            public string Title { get; set; }
            public int idNode { get; set; } 
            public List<Node> Childs { get; private set; }
            public Node Parent { get; set; }
            public bool IsFinish { get; set; }
            public string Level { get; set; }
            public int TypeNode { get; set; }

            // добавляем свойства узла для дерева подстанций
            // шина 
            public string Bus { get; set; }
            public int idBus { get; set; }
            // ячейка
            public string Cell { get; set; }
            public int idcell { get; set; }

            public string BranchList { get; set; }

            public Node(string title = null)
            {
                Title = title;
                Childs = new List<Node>();
                BranchList = "";
            }

            public Node(string title = null, int idnode = 0)
            {
                Title = title;
                idNode = idnode;
                Childs = new List<Node>();
                BranchList = "";
            }

            public Node(string title = null, int idnode = 0, string level = null)
            {
                Title = title;
                idNode = idnode;
                Childs = new List<Node>();
                Level = level;
                BranchList = "";
            }

            public Node(string title = null, int idnode = 0, string level = null, int TypeNode = 0)
            {
                Title = title;
                idNode = idnode;
                Childs = new List<Node>();
                Level = level;
                BranchList = "";
            }


            public IEnumerator<Node> GetEnumerator()
            {
                return Childs.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return Childs.GetEnumerator();
            }

            public override string ToString()
            {
                return Title;
            }

            public bool IsChildOf(Node parent)
            {
                return parent == Parent || (Parent != null && Parent.IsChildOf(parent));
            }

            public void AddChild(Node child)
            {
                Childs.Add(child);
                child.Parent = this;
            }

            public void InsertChild(Node child, int index)
            {
                Childs.Insert(index, child);
                child.Parent = this;
            }

            public void RemoveChild(Node child)
            {
                Childs.Remove(child);
                child.Parent = null;
            }

            public void AddBranch(string newNode)
            {
                BranchList += "/" + newNode;
            }



      
        }
    }

