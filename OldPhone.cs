using System;
using System.Linq;

public class OldPhone
{
    static public void Main ()
    {
        Console.WriteLine ("OLDPHONE");

        //Reading Input
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();
		
		//Print user Input
		Console.WriteLine(userInput);
		
		//Defined variables
		string finalresult;
		
		//get finalresult
		
		finalresult = OldPhonePad(userInput);
        
		//Print result
		Console.WriteLine("The result = "+ finalresult);
    }
	
	public static string OldPhonePad(string userInput){
	
    //check if the user input end with "#" character
	if (userInput.EndsWith("#")){
		
		//remove "#" character, excluded in validation of input
	   userInput = userInput.Remove(userInput.Length - 1);
	   
	
	   //split inputs by space and store to array string.
	   string[] inputs = userInput.Split(' ');
		//defined variable as empty string
		string result = "";
		//loop array for each input
		foreach (string input in inputs)
		{
		      //check if the user input has any special characters
	   		if (input.Any(p => ! char.IsLetterOrDigit(p)) || (input.Length == 0 || input.All(ch => ch == input[0]) == false)){
			return "??????";
		}
		//get total numbers of character
		 int keyPadNum = Convert.ToInt32(input.Substring(0, 1));
	    int numofChar = input.Length;
		 
		 switch(keyPadNum)
		 {
		    case 1:
			
			//I can used class here instead of switch.
			   switch (numofChar)
			 	{
				   
			  		case 1:
			       		result = result + "A";
				   		break;
			  		case 2:
			       		result = result + "B";
				   		break;
			  		case 3:
			       		result = result + "C";
				   		break;
			 	}
				break;
			 case 2:
				switch (numofChar)
			 	{
			
			  		case 1:
			       		result = result + "D";
				   		break;
			  		case 2:
			       		result = result + "E";
				   		break;
			  		case 3:
			       		result = result + "F";
				   		break;
			 	}
				break;
		 	}
			
		}
		return result;
	 }
	 else{
	 	return "Invalid input; The input should have # at the end.";
	 }
  }
}
