using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int share = 0; 
        int remain = 0;
        
        while(a<=n){
            share = (n / a) * b;
            remain = n % a;
            answer += share;
            n = share + remain;
        }
        return answer;
    }
}