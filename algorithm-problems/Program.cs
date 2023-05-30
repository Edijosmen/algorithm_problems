//using algorithm_problems.LightOJ;

//var pro = new Opposite_Task();
//pro.Run_Opposite_Task();
using algorithm_problems.HackerRang;

DiagonalDifference.Solutions();
//GrandeBook book = new GrandeBook();
//book.AddGrade(44.2F);
//book.AddGrade(54.2F);

//GrandeBook book2 = book;
//book2.AddGrade(78.6F);
//book2.AddGrade(78.6F);
//string raza = "dog";
//Console.WriteLine(raza);
//List<string> list = new List<string>();
//list.Add("hola1");
//list.Add("hola2");
//list.Add("hola3");
//(int, string) tq = (2, "uno");
//raza = "perros";

//Console.WriteLine(raza);

//Console.WriteLine(tq.Item1);
//foreach (string item in list)
//{

//    Console.WriteLine(item);
//}



public class GrandeBook{

    List<float> list = new();
    protected void AddGrade( float number)
    {
        list.Add(number);
    }
}