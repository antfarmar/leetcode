public class Solution003 {

    public static void main(String[] args) {
        String input = "abcabcbb";
        int answer = new Solution003().lengthOfLongestSubstring(input);
        System.out.println(answer);
    }

    public int lengthOfLongestSubstring(String s) {
        int n = s.length();
        int ans = 0;
        int[] index = new int[128]; // current index of character

        // Try to extend the range [i, j]
        for (int j = 0, i = 0; j < n; j++) {
            i = Math.max(index[s.charAt(j)], i);
            ans = Math.max(ans, j - i + 1);
            index[s.charAt(j)] = j + 1;
        }

        return ans;
    }
}