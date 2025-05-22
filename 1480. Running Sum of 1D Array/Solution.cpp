#include <bits/stdc++.h>
using namespace std;

class Solution {
public:
    vector<int> runningSum(vector<int>& nums) {
        int current = 0;
        for(int i = 0; i < nums.size(); i++){
            current += nums[i];
            nums[i] = current;
        }
        return nums;
    }
};

// Time: O(n)
// Space: O(1)