int solution(int[] inputArray) {
    int result = 0;
    for(int i=0; i<inputArray.Length-1; i++)
    {
        if(inputArray[i+1]<=inputArray[i])
        {
            result += inputArray[i]-inputArray[i+1] + 1;
            inputArray[i+1] = inputArray[i] + 1;
        }
    }
    return result;
}
