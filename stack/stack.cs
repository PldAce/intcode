public class Solution {
    public bool IsValid(string s) 
    {
        if(String.IsNullOrEmpty(s))
        {
            return true;
        }
        
        int length = s.Length;
        char[] word = s.ToCharArray();
        
        if (length % 2 != 0)
        {
            return false;
        }
        Stack myStack = new Stack();
        myStack.Push('-');
        
        for (int i = 0; i < s.Length; i ++)
        {
            if (myStack.Peek().Equals('(') && word[i].Equals(')'))
            {
                myStack.Pop();
            }

            else if (myStack.Peek().Equals('[') && word[i].Equals(']'))
            {
                myStack.Pop();
            }
            else if (myStack.Peek().Equals('{') && word[i].Equals('}'))
            {
                myStack.Pop();
            }
            else
            {
                myStack.Push(word[i]);            
            }

            
        }
        
        if(myStack.Peek().Equals('-'))
            return true;
        else
            return false;
        
    }
}
