using System;
public class Solution {
    public bool solution(int x) {
        bool answer = true;
        char[] y = x.ToString().ToCharArray();
        int sum = 0;
        for (int i=0; i<y.Length; i++){
            sum += (int)Char.GetNumericValue(y[i]);
        }
        if(x%sum==0){
            answer = true;
        }
        else{
            answer = false;
        }
        return answer;
    }
}