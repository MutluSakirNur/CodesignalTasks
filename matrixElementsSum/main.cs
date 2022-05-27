int solution(int[][] matrix) {
    int [][] mtrx = matrix;
    int result=0;
    for(int i=0;i < mtrx.GetLength(0); i++)
    {
        for(int j=0; j< mtrx[i].Length; j++)
        {
            if (mtrx[i][j] == 0)
            {
                if ((i+1)<matrix.GetLength(0))
                    mtrx[i+1][j] = 0;
            }
            else
                result += mtrx[i][j];
        }
    }
    return result;
}
