using static System.Console;

public class Program{

    public static string[] ArrayWidtElementLengthToTwo(string[] arr){
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i].Length <= 3){
                count++;
            }
        }

        string[] newArr = new string[count];
        count = 0;

        for(int i = 0; i < arr.Length; i++){
            if(arr[i].Length <= 3){
                newArr[count] = arr[i];
                count++;
            }
        }
        return newArr;
    }

    static void Main(){
        string[] arr = {"Hello", "Kazan", "world", ":-)"};
        string[] newArr = ArrayWidtElementLengthToTwo(arr);

        WriteLine($"New arr: [{string.Join(",", newArr)}]");
    }
}