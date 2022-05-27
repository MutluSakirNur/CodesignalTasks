int solution(int[] inputArray) {
    int maxproduct = inputArray[0]*inputArray[1];
    for(int i = 0; i < inputArray.Length-1; i++)
    {
        if((inputArray[i]*inputArray[i+1]) > maxproduct )
            maxproduct = (inputArray[i]*inputArray[i+1]);
    }
    return maxproduct;
}
