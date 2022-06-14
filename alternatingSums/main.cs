int[] solution(int[] a) {
    List<int> team1 = new List<int>();
    List<int> team2 = new List<int>();
    for(int i=0; i < a.Length; i++)
    {
        if((i%2)==0) //first index is zero 
            team1.Add(a[i]);
        else
            team2.Add(a[i]);
    }
    int[] result = new int[]{team1.Sum(),team2.Sum()};
    return result;
}
