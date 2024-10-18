Problem:

Using the language of your choice implement the following program named Shuffle:
Input a single integer N. Output the positive integers less than N in random order.
Optimize for speed.

Solution: 
Time complexity O(n)

Using parallization with fisher yates algorithm for shuffling numbers with each thread.

Results(ms)
Parallel
------------
Parallel N = 100000
Time 7516

Parallel N = 200000
Time 11084

Parallel N = 1000000
Time 43191

Sequential
----------------
Sequential N = 100000
Time 11491

Sequential N = 200000
Time 15360

Sequential N = 1000000
Time 61726
