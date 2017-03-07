# basic-algorithm

# Fibonucci

The Fibonacci Numbers is a sequence of numbers in the following order: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34... 
The next number is found by adding up the two numbers before it. The formula for calculating these numbers is:

# F(n) = F(n-1) + F(n-2)

where:

  F(n) is the term number.
  F(n-1) is the previous term (n-1).
  F(n-2) is the term before that (n-2). 

By definition, the first two numbers in the Fibonacci Sequence are either 0 and 1, or 1 and 1, depending on the chosen starting point of 
the sequence and each subsequent number is the sum of the previous two numbers.

This project contain 3 approaches.
	1. Basic iterative.
	2. Recursive.
	3. Nth number.
	
# Tower of Hanoi
The Tower of Hanoi (also called the Tower of Brahma or Lucas' Tower,[1] and sometimes pluralized) is a mathematical game or puzzle. 
It consists of three rods, and a number of disks of different sizes which can slide onto any rod. 
The puzzle starts with the disks in a neat stack in ascending order of size on one rod, the smallest at the top, thus making a conical shape.

The objective of the puzzle is to move the entire stack to another rod, obeying the following simple rules:

	1. Only one disk can be moved at a time.
	2. Each move consists of taking the upper disk from one of the stacks and placing it on top of another stack i.e. a disk can only be moved if it is the uppermost disk on a stack.
	3. No disk may be placed on top of a smaller disk.
With three disks, the puzzle can be solved in seven moves. The minimum number of moves required to solve a Tower of Hanoi puzzle is 2n – 1, where n is the number of disks.
#Refference https://en.wikipedia.org/wiki/Tower_of_Hanoi

#Sorting Algorithm

#Bubble Sort

Bubble sort, sometimes referred to as sinking sort, is a simple sorting algorithm that repeatedly steps through the list to be sorted, compares each pair of adjacent items and swaps them if they are in the wrong order. 
The pass through the list is repeated until no swaps are needed, which indicates that the list is sorted.
The algorithm, which is a comparison sort, is named for the way smaller or larger elements "bubble" to the top of the list. 
Although the algorithm is simple, it is too slow and impractical for most problems even when compared to insertion sort. 
It can be practical if the input is usually in sorted order but may occasionally have some out-of-order elements nearly in position.

#Refference https://en.wikipedia.org/wiki/Bubble_sort

#Selection Sort

In computer science, selection sort is a sorting algorithm, specifically an in-place comparison sort. It has O(n2) time complexity, making it inefficient on large lists, and generally performs worse than the similar insertion sort. 
Selection sort is noted for its simplicity, and it has performance advantages over more complicated algorithms in certain situations, particularly where auxiliary memory is limited.

The algorithm divides the input list into two parts: the sublist of items already sorted, which is built up from left to right at the front (left) of the list, and the sublist of items remaining to be sorted that occupy the rest of the list. 
Initially, the sorted sublist is empty and the unsorted sublist is the entire input list. The algorithm proceeds by finding the smallest (or largest, depending on sorting order) element in the unsorted sublist, exchanging (swapping) it with the leftmost unsorted element (putting it in sorted order), 
and moving the sublist boundaries one element to the right.


#Insertion Sort

Insertion sort is a simple sorting algorithm that builds the final sorted array (or list) one item at a time. It is much less efficient on large lists than more advanced algorithms such as quicksort, heapsort, or merge sort. 
However, insertion sort provides several advantages:

	1. Simple implementation: Jon Bentley shows a three-line C version, and a five-line optimized version[1]:116
	2. Efficient for (quite) small data sets, much like other quadratic sorting algorithms
	3. More efficient in practice than most other simple quadratic (i.e., O(n2)) algorithms such as selection sort or bubble sort
	4. Adaptive, i.e., efficient for data sets that are already substantially sorted: the time complexity is O(nk) when each element in the input is no more than k places away from its sorted position
	5. Stable; i.e., does not change the relative order of elements with equal keys
	6. In-place; i.e., only requires a constant amount O(1) of additional memory space
	7. Online; i.e., can sort a list as it receives it
When people manually sort cards in a bridge hand, most use a method that is similar to insertion sort.
#Refference https://en.wikipedia.org/wiki/Insertion_sort

#Shell Sort

Shellsort, also known as Shell sort or Shell's method, is an in-place comparison sort. It can be seen as either a generalization of sorting by exchange (bubble sort) or sorting by insertion (insertion sort).
The method starts by sorting pairs of elements far apart from each other, then progressively reducing the gap between elements to be compared. 
Starting with far apart elements, it can move some out-of-place elements into position faster than a simple nearest neighbor exchange. Donald Shell published the first version of this sort in 1959.
The running time of Shellsort is heavily dependent on the gap sequence it uses. For many practical variants, determining their time complexity remains an open problem.

#Refference https://en.wikipedia.org/wiki/Shellsort

#Quick Sort

Quicksort (sometimes called partition-exchange sort) is an efficient sorting algorithm, serving as a systematic method for placing the elements of an array in order. 
Developed by Tony Hoare in 1959,[1] with his work published in 1961,[2] it is still a commonly used algorithm for sorting. 
When implemented well, it can be about two or three times faster than its main competitors, merge sort and heapsort.

Quicksort is a comparison sort, meaning that it can sort items of any type for which a "less-than" relation (formally, a total order) is defined. 
In efficient implementations it is not a stable sort, meaning that the relative order of equal sort items is not preserved. Quicksort can operate in-place on an array, requiring small additional amounts of memory to perform the sorting.

Mathematical analysis of quicksort shows that, on average, the algorithm takes O(n log n) comparisons to sort n items. In the worst case, it makes O(n2) comparisons, though this behavior is rare.


#Refference https://en.wikipedia.org/wiki/Quicksort

# Merge Sort

In computer science, merge sort (also commonly spelled mergesort) is an efficient, general-purpose, comparison-based sorting algorithm. Most implementations produce a stable sort, 
which means that the implementation preserves the input order of equal elements in the sorted output. Mergesort is a divide and conquer algorithm that was invented by John von Neumann in 1945.
A detailed description and analysis of bottom-up mergesort appeared in a report by Goldstine and Neumann as early as 1948.

#Refference https://en.wikipedia.org/wiki/Merge_sort
#Refference https://en.wikipedia.org/wiki/Sorting_algorithm#Stability


#Searching Algorithm

#Linear Search

In computer science, linear search or sequential search is a method for finding a target value within a list. It sequentially checks each element of the list for the target value until a match is found or until all the elements have been searched.
Linear search runs in at worst linear time and makes at most n comparisons, where n is the length of the list. If each element is equally likely to be searched, then linear search has an average case of n/2 comparisons, but the average case can be affected if the search probabilities for each element vary. 
Linear search is rarely practical because other search algorithms and schemes, such as the binary search algorithm and hash tables, allow significantly faster searching for all but short lists.

 #Refference https://en.wikipedia.org/wiki/Linear_search

 #Binary Search

 In computer science, binary search, also known as half-interval search[1] or logarithmic search,[2] is a search algorithm that finds the position of a target value within a sorted array. Binary search compares the target value to the middle element of the array; 
 if they are unequal, the half in which the target cannot lie is eliminated and the search continues on the remaining half until it is successful or the remaining half is empty.
Binary search runs in at worst logarithmic time, making O(log n) comparisons, where n is the number of elements in the array, the O is Big O notation, and log is the logarithm. 
Binary search takes only constant (O(1)) space, meaning that the space taken by the algorithm is the same for any number of elements in the array.
Although specialized data structures designed for fast searching—such as hash tables—can be searched more efficiently, binary search applies to a wider range of search problems.

Although the idea is simple, implementing binary search correctly requires attention to some subtleties about its exit conditions and midpoint calculation.

There exist numerous variations of binary search. In particular, fractional cascading speeds up binary searches for the same value in multiple arrays, efficiently solving a series of search problems in computational geometry and numerous other fields. Exponential search extends binary search to unbounded lists. The binary search tree and B-tree data structures are based on binary search.

#Refference https://en.wikipedia.org/wiki/Binary_search_algorithm
#Refference https://en.wikipedia.org/wiki/Search_algorithm