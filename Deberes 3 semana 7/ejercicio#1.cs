using System;
using System.Collections.Generic;

public class Program
{
    public static bool AreParenthesesBalanced(string expression)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char ch in expression)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                if (stack.Count == 0)
                    return false;
                
                char openBracket = stack.Pop();
                if (!IsMatchingPair(openBracket, ch))
                    return false;
            }
        }
        
        return stack.Count == 0;
    }

    private static bool IsMatchingPair(char openBracket, char closeBracket)
    {
        return (openBracket == '(' && closeBracket == ')') ||
               (openBracket == '{' && closeBracket == '}') ||
               (openBracket == '[' && closeBracket == ']');
    }

    public static void Main()
    {
        string expression = "{7+(8*5)-[(9-7)+(4+1)]}";
        if (AreParenthesesBalanced(expression))
            Console.WriteLine("Formula balanceada");
        else
            Console.WriteLine("Formula no balanceada");
    }
}
