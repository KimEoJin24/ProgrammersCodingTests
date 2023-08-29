using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] m = n.ToString().ToCharArray();
        Array.Sort(m);
        Array.Reverse(m);
        answer = long.Parse(m);
        return answer;
    }
}