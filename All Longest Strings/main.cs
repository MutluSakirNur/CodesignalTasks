string[] solution(string[] inputArray) {
    int maxStringSize = 0;
    List<string> maxStrings = new List<string>();
    for(int i=0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length>maxStringSize)
        {
            maxStringSize = inputArray[i].Length;
            maxStrings.Clear();
            maxStrings.Add(inputArray[i]);
        }
        else if(inputArray[i].Length==maxStringSize)
        {
            maxStrings.Add(inputArray[i]);
        }
    }
    return maxStrings.ToArray();
}
