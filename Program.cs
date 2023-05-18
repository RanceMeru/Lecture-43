class Program
{
    static void Main(string[] args)
    {
        int studentGrade = 75;
        ExtraCreditRef(ref studentGrade);
        Console.WriteLine(studentGrade);
    //for this example it would be the same with or without the ref keyword
    }
    static void ExtraCreditRef( ref int studentGrade)
    {
            studentGrade +=3;

    }
}