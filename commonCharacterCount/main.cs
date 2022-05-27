int solution(string s1, string s2) {
    List<char> str1 = new List<char>();
    List<char> str2 = new List<char>();
    str1 = s1.ToCharArray().ToList();
    str2 = s2.ToCharArray().ToList();
    int countOfCommons = 0;
    for(int i=0; i<str1.Count; i++)
    {
        for(int j=0; j<str2.Count; j++)
        {
            if(str1[i]==str2[j])
            {
                //str1.RemoveAt(i); it's not necessary
                str2.RemoveAt(j);
                countOfCommons++;
                break;
            }
        }
    }
    return countOfCommons;
}
