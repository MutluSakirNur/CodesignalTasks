int solution(int n) {
    // 2 -> 2*2 + 1*1   3 -> 3*3 + 2*2  n -> n*n + n-1*n-1
    return (n*n) + (n-1)*(n-1);
}
