public class Solution {
    public int Reverse(int x) 
    {
        int rev = 0;
        int pop;
        int result = 0;
        int val = 1;
        int overflow = int.MaxValue / 10;
        if (x < 0)
        {
            val = -1;
            x = x * val;
        }
        
        while(x > 0)
        {
            if(result > overflow)
            {
				return 0;
            }

            pop = x % 10;
            x = x / 10;
            
            result = result * 10 + pop;



        }
        
        return result * val;
        
    }
}
