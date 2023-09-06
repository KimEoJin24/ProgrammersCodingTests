using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = -1;
        for (int i=0; i<numbers.Length; i++){
            answer += numbers[i];
        }
        answer = 44 - answer;
        return answer;
    }
}