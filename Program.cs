// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args) 
    { 
        PemrosesanData p = new PemrosesanData();
        float a = 10;
        float b = 30; 
        float c = 22;
        p.DapatkanNilaiTerbesar(a, b, c);
    }
}
class PemrosesanData
{
    public void DapatkanNilaiTerbesar<T>(T t1, T t2, T t3)
    {
        dynamic a1 = t1;
        dynamic a2 = t2;
        dynamic a3 = t3;

        if (a1 > a2 && a1 > a3)
        {
            Console.WriteLine($"{t1}");
        }
        else if (a2 > a1 && a2 > a3)
        {
            Console.WriteLine($"{t2}");
        }
        else
        {
            Console.WriteLine($"{t3}");
        }
    }
    
class SimpleDataBase<T>
{ 
    private List<T> storedata;
    private List<DateTime> inputDates;

    public void simpleDataBase() { 
       storedata = new List<T>();
       inputDates = new List<DateTime>();
    }
    public void addNewData(T data) { 
        storedata.Add(data);
        DateTime currentTime = DateTime.Now;
        inputDates.Add(currentTime);
    }
    public void PrintAlldata() {
        for (int i = 0; i < storedata.Count; i++) {
            Console.WriteLine($"Data   {i+1}  Berisi:  { storedata[i]}, yang disimpan pada waktu UTC: { inputDates[i]}");
        }
    }
   
}
    class Program
    {
        public static void Main(string[] args)
        {
            SimpleDataBase<float> a = new SimpleDataBase<float>();
            a.addNewData(12);
            a.addNewData(13);
            a.addNewData(14);
            a.PrintAlldata();

        }
    }
}
