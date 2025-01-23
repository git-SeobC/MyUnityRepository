namespace PJT250123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int -> 정수
            // float -> 실수
            // char -> 유니코드 한글자 'A' -> 65
            // +, -, *, /, %
            // 대입문 '='

            int korean = 10;
            int mathmatics = 100;
            int english = 50;

            int sum = korean + mathmatics + english;
            float average = (float)sum / 3.0f;
            // average = 0; 여기에서 0만이 .0f를 안씀(자료형이 float 이면)
            
            Console.WriteLine(average);
        }
    }
}
