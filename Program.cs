// See https://aka.ms/new-console-template for more information

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
