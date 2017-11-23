using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14725 {
    class Program {
        private class Node : IComparable {
            public string name;
            public List<Node> child;

            public Node(string name) {
                this.name = name;
                child = new List<Node>();
            }
            
            public Node hasChild(string name) { // 해당 이름의 자식을 가지고 있는지 확인한다.
                for(int i=0; i<child.Count; i++) {
                    if(child[i].name == name) {
                        return child[i];
                    }
                }
                return null;
            }

            public void printChild(int index) {
                child.Sort();
                for(int i=0; i<child.Count; i++) {
                    for (int j = 0; j < index; j++) {
                        Console.Write("--");
                    }
                    Console.WriteLine(child[i].name);
                    if (child[i].child.Count > 0) {
                        child[i].printChild(index + 1);
                    }
                }
            }

            public Node addChild(Node node) {
                child.Add(node);
                return node;
            }

            public int CompareTo(object obj) {
                return name.CompareTo(((Node)obj).name);
            }
        }

        static void Main(string[] args) {
            int inputLength = int.Parse(Console.ReadLine()); // 값을 읽어온다.
            Node topNode = new Node("Top Node");
            for (int i = 0; i < inputLength; i++) {
                string[] input = Console.ReadLine().Split(' ');
                Node node = topNode;
                for (int j = 1; j < input.Length; j++) {
                    Node temp = node.hasChild(input[j]);
                    if (temp == null) {
                        node = node.addChild(new Node(input[j]));
                    } else {
                        node = temp;
                    }
                }
            }
            topNode.printChild(0);
        }
    }
}
