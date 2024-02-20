using System; //여기서 시스템은 네임스페이스를 의미
//이걸 함으로써 시스템안에 있는 기능들을 사용하겠다라고 선언

// 네임스페이스는 클래스들의 묶음 내지는 어떠한 기능들의 묶음이라고 생각하면 됨
namespace HelloWorld
{
    internal class Program
    {
     
        // 메인 메서드. 프로그램을 시작했을때 가장 처음으로 호출됨
        static void Main(string[] args)
        {
            //시스템을 using 함으로써 쓸수 있는 코드 Console.WriteLine();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("C#");
            Console.WriteLine("study");

            for (int i = 0; i < 10; i++) { }
        
        }
    }
}
