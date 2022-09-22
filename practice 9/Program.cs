using System;
using System.Linq;

public static class practice_9
{
    
    static void Main()
    {
        string[] Number = Console.ReadLine().Split(' '); //숫자를 입력받음

        for(int i=0;i<Number.Length; i++)
        {
            int Num = int.Parse(Number[i]);  // 입력받은 숫자를 저장
            
          }
        System.Console.WriteLine(Number.Max()); // 저장된 숫자중 가장 큰 숫자 출력
        
    }
}        
            



        

