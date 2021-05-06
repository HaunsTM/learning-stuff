using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    class _7_StacksAndQueues_Nesting
    {   
        private bool isCorrespondingParentheses(char nestCharacterStart, char nestCharacterEnd)
        {
            var isValid = false;

            if (nestCharacterStart == '(' && nestCharacterEnd == ')')
            {
                isValid = true;
            }

            return isValid;
        }

        public int solution(string S)
        {
            const int IS_NOT_PROPERLY_NESTED = 0;
            const int IS_PROPERLY_NESTED = 1;

            var charStack = new Stack<char>();

            //split input string to char array
            var characterArray = S.ToCharArray();

            foreach (var character in characterArray)
            {
                if (character == '(') 
                {
                    // we have found an opening parenthese, put it on the character stack
                    charStack.Push(character);
                } 
                else if (character == ')')//need to check for 
                {
                    // if we do not have any character on the stack when we are here, it's impossible that the parentheses are properly corresponding
                    if (charStack.Count == 0) 
                        return IS_NOT_PROPERLY_NESTED; 

                    // remove topmost character from stack 
                    var topmostChar = charStack.Pop();
                    var nestCharacterStart = topmostChar;
                    var nestCharacterEnd = character;

                    // verify corresponding pair of parentheses
                    if (!isCorrespondingParentheses(nestCharacterStart, nestCharacterEnd))
                    {
                        return IS_NOT_PROPERLY_NESTED;
                    }
                }
            }

            // if we end up here, the character stack should be empty
            if (charStack.Count != 0)
                return IS_NOT_PROPERLY_NESTED;

            return IS_PROPERLY_NESTED;
        }
    }
}
