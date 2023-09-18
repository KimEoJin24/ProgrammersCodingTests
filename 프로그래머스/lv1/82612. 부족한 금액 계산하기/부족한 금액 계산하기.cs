class Solution
{
    public long solution(int price, int money, int count)
    {
        long sumPrice = 0;
        long result = 0;
        for(int i=1; i<= count; i++){
            sumPrice += price * i;
        }
        result = sumPrice-money;
        if(result<=0){
            return 0;
        }
        
        return result;
    }
}