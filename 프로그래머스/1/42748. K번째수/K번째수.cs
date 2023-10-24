using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        for(int n=0; n<commands.GetLength(0); n++){
            int i = commands[n, 0];
            int j = commands[n, 1]; 
            int k = commands[n, 2];
            
            int[] subArray = new int[j-i+1];
            for(int m=0; m<j-i+1; m++){
                subArray[m] = array[i-1+m];
            }
            Array.Sort(subArray);
            answer[n] = subArray[k-1];
        }
        return answer;
    }
}