public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data.ToString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> data = new DataGeneric<string>("103022300146");
        data.PrintData();
    }
}