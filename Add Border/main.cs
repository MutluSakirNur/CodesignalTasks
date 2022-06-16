string[] solution(string[] picture) {
    int size = picture.Max(w => w.Length) + 2;
    string asteriks = string.Empty;
    for(int i=0; i<size; i++)
        asteriks += "*";
    List<string> result = new List<string>();
    for(int i=0; i<picture.Length; i++)
    {
        if(i==0)
            result.Add(asteriks);
        if(i==picture.Length-1)
        {
            result.Add("*" + picture[i] + "*");
            result.Add(asteriks);
            return result.ToArray();
        }
        result.Add("*" + picture[i] + "*");
    }
    return result.ToArray();
}
