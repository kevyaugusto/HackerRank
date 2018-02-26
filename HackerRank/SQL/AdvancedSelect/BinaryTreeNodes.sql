/*
Binary Tree Nodes

You are given a table, BST, containing two columns: N and P, where N represents the value of a node in Binary Tree, and P is the parent of N.

Write a query to find the node type of Binary Tree ordered by the value of the node. Output one of the following for each node:

Root: If node is root node.
Leaf: If node is leaf node.
Inner: If node is neither root nor leaf node.

*/

SELECT 
	n,
	case
		when p is null then 'Root'
		when exists(select p from bst t1 where t1.p = t0.n) then 'Inner'
		else 'Leaf'
	end as description
from [bst] t0
order by 1