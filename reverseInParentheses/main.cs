string solution(string inputString) {
    string stringtoReverse = string.Empty;
    string result = string.Empty;
    int findflag = 0;
    for(int i=0;i < inputString.Length; i++)
    {
        if(inputString.Contains('(') && inputString.Contains(')'))
        {
            if( !(inputString[i] == '(' || inputString[i] == ')') && findflag > 0)
            {
                stringtoReverse += inputString[i];
                Console.WriteLine("1.if");
            }
            else if(inputString[i] == '(')
            {
                Console.WriteLine("2.if");
                findflag++;
                if(findflag>1)
                {
                    stringtoReverse += ')';
                }
            }
            else if(inputString[i] == ')')
            {
                Console.WriteLine("3.if");
                findflag--;
                if(findflag == 0)
                {
                    Console.WriteLine(result);
                    Console.WriteLine(new string(stringtoReverse.Reverse().ToArray()));
                    Console.WriteLine(inputString.Substring(i+1));
                    result = result + new string(stringtoReverse.Reverse().ToArray()) + inputString.Substring(i+1);
                    Console.WriteLine(result);
                    i = -1;
                    inputString = result;
                    
                    stringtoReverse = string.Empty;
                    result = string.Empty;
                    Console.WriteLine(inputString);
                }
                else
                {
                    stringtoReverse += '(';
                }
            }
            else
            {
                Console.WriteLine(inputString[i]);
                result += inputString[i];
            }
        }
        else
        {
            return inputString;
        }
    }
    return inputString;
}
