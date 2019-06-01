
# Binary Search Tree as String 

This app will compare strings and add to binary search tree.

## Getting Started
These project help for you when you use with strings and binarysearchTrees. You can get binary search tree as alphabetical order with this app.

### Installing
Create a new class **BinarySearchTree** and **TreeNode** *for* **BinarySearchTree** 

Creating Node for BinarySearchTreeString
```
Public Class TreeNode{
	//will take string data
	public string m_Data;
        public TreeNodeLeft;
        public TreeNodeRight;
       //Node's have left and right childs.
       
  //This Constructor will using for null nodes
   public TreeNode()
        {

        }

  
  //This Constructor will using for not null nodes
   public Node(string data)
        {
            this.m_Data = data;
            Left = null;
            Right = null;
        }
}
```

Create  BinarySearchTree for String
```
Public Class StringBinarySearchTree{  
	
	 TreeNode Root;
        //will take all of nodes
        private string Nodes;
	    
	    //Adding nodes
        public void Add(string NewWord)
        {

            //NodeToAdd's parent
            TreeNode tempParent = new TreeNode();
            int StringCompare;



            //Start From root and traverse
            TreeNode tempSearch = Root;
            //until tempsearch will be null
            while (tempSearch != null)
            {
                tempParent = tempSearch;
                StringCompare = string.Compare(NewWord, tempSearch.m_Data);
                //string has exist exit
                if (NewWord== tempSearch.m_Data)
                    return;
                else if (StringCompare == -1)
                    tempSearch = tempSearch.Left;
                else
                    tempSearch = tempSearch.Right;
            }
            
            //create the new Node for add to Tree
            TreeNode NodeToAdd = new TreeNode(NewWord);

            //COMPARE STRING DATA'S
            StringCompare = string.Compare(NewWord, tempParent.m_Data);

            //Tree is empty add to root.

            if (Root == null)
                Root = NodeToAdd;
            else if (StringCompare == -1)
                tempParent.Left = NodeToAdd;
            else
                tempParent.Right = NodeToAdd;
        }

        //Sorted Tree can take with InOrder  
        public void InOrder()
        {
            Nodes = "";
            //send to root for sort
            InOrderString(Root);
        }
        private void InOrderString(TreeNode TraverseNode)
        {
           //if null return else follow in order line 
            if (TraverseNode == null)
                return;
            InOrderString(TraverseNode.Left);
            Visit(TraverseNode);
            InOrderString(TraverseNode.Right);
        }
        //take visited node's data
        private void Visit(TreeNode TraverseNode)
        {
                Nodes += TraverseNode.m_Data + " ";      
        }
        //will return as string data
        public string GetNodes()
        {
            return Nodes;
        }
}
```
We created our BinarySearchTree and Node Lets try them.

### And coding style tests
Try to add 5 string data to our tree.

```
void Main(string[] args)
        {
            StringBinarySearchTree Tree = new StringBinarySearchTree();
            Tree.Add("Ayşe");
            Tree.Add("Fatma");
            Tree.Add("Hayriye");
            Tree.Add("Ali");
            Tree.Add("Demet");
		
	    //Use InOrder for alphabetical order	
            Tree.InOrder();
            Console.WriteLine("{0}", Tree.GetNodes());
            Console.ReadKey();

        }
```

Will return 
```
Ali Ayse Demet Fatma Hayriye
```
![Sample](https://user-images.githubusercontent.com/9121424/58753028-303a2580-84a8-11e9-9fe2-b95084608c3a.jpg)



## Authors

* **Bilal Başulaş*** - *Initial work* - [bsBilal](https://github.com/bsBilal)


