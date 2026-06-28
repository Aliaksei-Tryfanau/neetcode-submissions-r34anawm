class Solution 
{
public:
    bool hasDuplicate(vector<int>& nums) 
    {
        // unordered_set<int> seen;

        // for (int num : nums) 
        // {
        //     if (seen.count(num)) 
        //     {
        //         return true;
        //     }
        //     seen.insert(num);
        // }
        // return false;

        return unordered_set<int>(nums.begin(), nums.end()).size() < nums.size();
    }
};