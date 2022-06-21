bool solution(string inputString) {
    string[] inputs = inputString.Split('.');
    int num;
    if(inputs.Length!=4)
        return false;
    for(int i=0;i < inputs.Length; i++)
    {
        try
        {
            string temp = inputs[i];
            if(temp[0] == '0' && temp.Length > 1)
                return false;
            num = Int32.Parse(inputs[i]);
            if(num > 255 || num < 0)
                return false;
        }
        catch
        {
            return false;
        }
    }
    return true;
}
