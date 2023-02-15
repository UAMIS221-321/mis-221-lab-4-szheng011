// start main
int option = -1;

while(option != 3){
    DisplayMenu();
    if(IsValidOption(ref option)){
        Triangle(option);
    }
}
return;
// end main

static void DisplayMenu(){
    System.Console.WriteLine("\nEnter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidOption(ref int option){
    string userInput = (Console.ReadLine());
    if (userInput == "1" || userInput == "2" || userInput == "3"){
        option = int.Parse(userInput);
        return true;
    }
    else {
        System.Console.WriteLine("Invalid Choice, please try again:");
        return false;
    }
}

static void Triangle(int option){
    if(option == 1){
        GetFull();
    }
    else if(option == 2){
        GetPartial();
    }
    else return;
}

static void GetFull(){
    Random rnd = new Random();
    int row = rnd.Next(3,10); //generates a random number in the range 3 to 9
    System.Console.WriteLine("Full Triange; Random number of rows: " + row);

    for (int i = 0; i <= row; i++){
        for (int j = 0; j < i; j++){
            System.Console.Write("O ");
        }
        System.Console.Write("\n");
    }
}

static void GetPartial(){
    Random rnd = new Random();
    int row = rnd.Next(3,10); //generates a random number in the range 3 to 9
    System.Console.WriteLine("Partial Triangle; Random number of rows: "+ row);

    for (int i = 0; i <= row; i++){
        Random rndm = new Random();
        int num = rndm.Next(2); //generates a random number 0 or 1

        for (int j = 0; j < i; j++){
            if(num == 1){
                System.Console.Write("O "); 
                num = rndm.Next(2);
            }
            else{
                System.Console.Write("  ");
                num = rndm.Next(2);
            }
        }
        System.Console.Write("\n");
    }
}