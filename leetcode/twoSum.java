package leetcode;

import java.util.Scanner;

class Solution {
    
    public int[] twoSum(int[] nums, int target) {
    for (int i = 0; i < nums.length; i++) {
        for (int j = i + 1; j < nums.length; j++) {
            if (nums[j] == target - nums[i]) {
                return new int[] { i, j };
            }
        }
    }
    throw new IllegalArgumentException("No two sum solution");
    }


    public static void main() {

        Scanner s = new Scanner(System.in);
        int n = s.nextInt();
        int[] nums = new int[n];

        
        
    }
}