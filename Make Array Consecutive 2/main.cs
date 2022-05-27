int solution(int[] statues) {
    Array.Sort(statues);
    int numberOfStatues = 0;
    for(int i=0; i < statues.Length-1; i++)
    {
        if(statues[i] != statues[i+1]-1)
            numberOfStatues += statues[i+1] - statues[i]-1;
    }
    return numberOfStatues;
}
