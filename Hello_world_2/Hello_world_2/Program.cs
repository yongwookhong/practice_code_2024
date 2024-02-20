namespace Hello_world_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My Name is Kero");

            Console.WriteLine(10);
            Console.WriteLine(3.141592);
            Console.WriteLine(3 + 3);

            Console.WriteLine("hey");

            //wirte는 출력하고 다른줄로 내려오지 않는다
            Console.Write("Hello! ");
            Console.Write("We are Learning ");
            Console.WriteLine("at TeamSparta");

            // \n 은 줄을바꿔줌
            Console.WriteLine("Hello\nWorld");
            // 출력결과
            // Hello
            // World

            // \t 는 tab을 넣어줌 8칸 띄어준다.
            Console.WriteLine("Name\tAge");
            Console.WriteLine("Kero\t30");
            Console.WriteLine("Young\t25");
            // 출력결과
            // Name    Age
            // Kero    30
            // Young   25

            // \" 큰따음표 삽입
            Console.WriteLine("We learn \"C# Programming\"");
            // 출력결과
            // The book is called "C# Programming"

            // \' 작은 따음표 삽입
            Console.WriteLine("He said, \'Hello\' to me.");
            // 출력결과
            // He said, 'Hello' to me.

            // \\ 역슬래쉬 넣기 경로 넣을때
            Console.WriteLine("C:\\MyDocuments\\Project\\");
            // 출력결과
            // C:\MyDocuments\Project\
        }
    }
}
