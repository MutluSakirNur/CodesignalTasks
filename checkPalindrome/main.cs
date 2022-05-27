bool solution(string inputString) {
    int leng = inputString.Length;
    for (int i = 0; i< leng -1; i++)
    {
        if (inputString[i] != inputString[leng-i-1])
            return false;
    }
    return true;

}
