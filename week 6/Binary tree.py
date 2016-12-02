class BinTreeNode(object):
 
    def __init__(self, value):
        self.value=value
        self.left=None
        self.right=None
 
 
       
def tree_insert( tree, item):
    if tree==None:
        tree=BinTreeNode(item)
    else:
        if(item < tree.value):
            if(tree.left==None):
                tree.left=BinTreeNode(item)
            else:
                tree_insert(tree.left,item)
        else:
            if(tree.right==None):
                tree.right=BinTreeNode(item)
            else:
                tree_insert(tree.right,item)
    return tree
 
def postorder(tree):
    if(tree.left!=None):
        postorder(tree.left)
    if(tree.right!=None):
        postorder(tree.right)
    print (tree.value)
    
def in_order(tree):
    while (tree != None):
        if (tree.left == None): #checks the left value before traveling there
            print(tree.value) #prints leftmost value
            tree = tree.right # goes to right since there is no left
        else:
            up = tree.left
            while (up.right != None and up.right != tree): 
                up = up.right #going to rightmost node
            if (up.right == None):
                up.right = tree # now goes to the right side of the tree
                tree = tree.left
            else:
                print(tree.value)
                tree = tree.right
        
##def in_order(tree):
##    if(tree.left!=None):
##        in_order(tree.left)
##    print (tree.left, tree.value,tree.right)
##    
##    if(tree.right!=None):
##        in_order(tree.right)
 
if __name__ == '__main__':
   
  t=tree_insert(None,6) 
  tree_insert(t,2)
  tree_insert(t,1)
  tree_insert(t,10)
  tree_insert(t,7)
  tree_insert(t,4)
  tree_insert(t,3)
  in_order(t)
