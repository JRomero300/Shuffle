**Problem Statement**

Implement a program named Shuffle in your preferred programming language. The program should:

Accept a single integer input, N.
Output the positive integers less than N in a random order.

**Requirements**

Optimize the implementation for speed.

**Proposed Solution**

Time Complexity: O(n)
Utilize parallelization combined with the Fisher-Yates shuffle algorithm for efficiently shuffling the integers across multiple threads.

**Performance Results**

The following results demonstrate the performance of both parallel and sequential implementations of the Shuffle program:

Parallel(ms)
--------------------------------------

Parallel N = 100000
Time 7516

Parallel N = 200000
Time 11084

Parallel N = 1000000
Time 43191

Sequential(ms)
----------------
Sequential N = 100000
Time 11491

Sequential N = 200000
Time 15360

Sequential N = 1000000
Time 61726

**Observations**

The parallel implementation significantly reduces execution time compared to the sequential implementation, especially as N increases.
Although parallelization introduces some overhead, the performance gain becomes more pronounced with larger datasets, demonstrating the effectiveness of using multiple threads for this problem.
