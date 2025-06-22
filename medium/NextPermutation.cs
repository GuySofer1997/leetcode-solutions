public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int n = nums.Length;
        int first_decrease = -1;
        for (int i = n - 2; i >= 0; i--)
        {
            if (nums[i] < nums[i + 1])
            {
                first_decrease = i;
                break;
            }
        }
        if (first_decrease == -1)
        {
            Array.Reverse(nums);
            return;
        }

        for (int j = n - 1; j > first_decrease; j--)
        {
            if (nums[j] > nums[first_decrease])
            {
                Swap(nums, first_decrease, j);
                break;
            }
        }
        Array.Reverse(nums, first_decrease + 1, n - first_decrease - 1);
    }

    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}