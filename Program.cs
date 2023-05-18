class Program
{
    static void Main(string[] args)
    {
        int studentGrade = 75;
        ExtraCreditRef(ref studentGrade);
        Console.WriteLine(studentGrade);
    
    }
    static void ExtraCreditRef(ref int studentGrade)
    {
            studentGrade +=3;

    }
}