namespace Assignment;

public class Program
{
    public static int returnVowel(String myString) {
        int vowelCount;
        vowelCount = 0;

        
        int len = myString.Length;
        if (myString == null) {
            Console.Write("Enter a correct input");
            return 0;

        }
        else if (myString == "") {
            Console.Write("Enter a correct input");
            return 0;

        }


        else {
            
            for (int i = 0; i<len; i++) {

                if (myString[i] =='a' || myString[i]=='e' || myString[i]=='i' || myString[i]=='o' || myString[i]=='u' || myString[i]=='A'
                || myString[i]=='E' || myString[i]=='I' || myString[i]=='O' || myString[i]=='U') {
                
                    vowelCount++;

                }
            
            }   
            Console.Write("\nVowels in the string: {0}\n", vowelCount);
            return vowelCount;  
        }

        
    }

    public static void Main() {
    }

    // Return 0 for non-string inputs (null)
    // Return 0 if input string is empty
}