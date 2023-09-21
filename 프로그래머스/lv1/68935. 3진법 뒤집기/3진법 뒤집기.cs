using System;
using System.Collections.Generic;
using static System.Math;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> trit = new List<int>();
        while(n>0){
            int num = n % 3;
            trit.Add(num);
            n /= 3;
        }
        for(int i=trit.Count-1; i>=0; i--){
            answer += (int)(trit[trit.Count-i-1] * Math.Pow(3,i));
        }
        return answer;
    }
}