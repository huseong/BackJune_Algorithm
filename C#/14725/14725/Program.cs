using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14725 {
    class Program {
        private class Node {
            public string name;
            public List<Node> child;
            public Node(string name) {
                this.name = name;
                child = new List<Node>();
            }

            public Node hasChild(string name) {
                for(int i=0; i<child.Count; i++) {
                    if(child[i].name == name) {
                        return child[i];
                    }
                }
                return null;
            }

            public void printChild() {
                for(int i=0; i<child.Count; i++) {

                }
            }
        }
        static void Main(string[] args) {
            int infoLength = int.Parse(Console.ReadLine());
            Node topNode = new Node("TopNode");
            for(int i=0; i<infoLength; i++) {
                string[] input = Console.ReadLine().Split(' ');
                int length = int.Parse(input[0]);
                Node node = null;
                if ((node = topNode.hasChild(input[1])) == null) {
                    node = new Node(input[1]);
                    topNode.child.Add(node); 
                }
                for (int j=2; j<length; j++) {
                    Node tempNode = node.hasChild(input[j]);
                    if(tempNode == null) {
                        Node teempNode = node;
                        for(int k=j; k<length; k++) {
                            Node newNode = new Node(input[k]);
                            teempNode.child.Add(newNode);
                            teempNode = newNode;
                        }
                        continue;
                    }
                    node = tempNode;
                }
            }
            topNode.
        }
    }
}
