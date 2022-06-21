int solution(int[] inputArray) {
    int divider = 2;
    for(int i=0; i<inputArray.Length; i++)
    {
        if(inputArray[i]%divider == 0)
        {
            divider++;
            i = -1;
        }
    }
    return divider;
}
