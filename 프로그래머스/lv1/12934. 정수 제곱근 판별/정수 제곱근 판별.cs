using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        long m = (long)Math.Sqrt(n);
        answer = (m*m==n) ? (m+1)*(m+1) : -1;
        return answer;
    }
}