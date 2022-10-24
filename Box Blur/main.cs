int[][] solution(int[][] image) {
    int tempAvg;
    int[][] resultArray = new int[image.Length-2][];
    for(int i=0; i < image.Length-2; i++)
    {
        resultArray[i] = new int[image[0].Length-2];
        for(int j=0; j < image[0].Length-2; j++)
        {
            tempAvg = (image[i][j] + image[i+1][j] + image[i+2][j] + image[i][j+1] + image[i][j+2] + image[i+1][j+1] + image[i+2][j+2] + image[i+2][j+1] + image[i+1][j+2]) / 9;
            resultArray[i][j] = tempAvg;
        }
    }
    return resultArray;
}
