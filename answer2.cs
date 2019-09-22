using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution {

  static int solution(int[] A) {
    int check = 1;
  int  i = 0;
    for(i=0; i<4; i++)
    {
      if(A[i] > A[0])
      { check = 2;
       }
    }
    return  check;
  }
  static void Main(String[] args) {
    // Read from stdin, solve the problem, write answer to stdout.
    int[] A = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

    Console.Write(solution(A));
  }
}
