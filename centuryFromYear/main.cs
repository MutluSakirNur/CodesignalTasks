int solution(int year) {
    string year_s = year.ToString();
    if (year <= 100)
        return 1;
    if (year % 100 == 0)
    {
        if (year < 1000)
            year_s = year_s.Substring(0,1);
        else
            year_s = year_s.Substring(0,2);
        return Int32.Parse(year_s);
    }
    else
    {
        if (year < 1000)
            year_s = year_s.Substring(0,1);
        else
            year_s = year_s.Substring(0,2);
        return Int32.Parse(year_s) + 1;
    }
    
}
