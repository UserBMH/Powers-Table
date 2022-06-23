//Display a table of powers
int loop = 0;


do
{


    //ask user for int
    Console.WriteLine("Enter an Integer:");
    int userInput = int.Parse(Console.ReadLine());
    int userInputCalc = userInput;


    if (userInput >= 0 && userInput <= 1290)
    {
        //userInputCalc is equal to userInput except will decrease by 1 for each loop to increase the value by 1 per step. This will allow the loop to count 1..2..3..4..5 
        //Until UserInputCalc = 0 at which point the loop will end.

        Console.WriteLine("");
        Console.WriteLine("");


        //Header formating on table
        Console.WriteLine("I HAVE THE POWER!");
        Console.WriteLine("");
        Console.WriteLine("Enter an Integer:   " + userInput);
        Console.WriteLine("");

        //display table of squares and cubes from 1 to value entered
        Console.WriteLine(String.Format("{0,-10}  {1,-10}  {2,10}","Number", "Squared", "Cubed"));
        Console.WriteLine(String.Format("{0,-10}  {1,-10}  {2,10}","======", "=======", "====="));

           

        //While loop
        while (userInputCalc > 0)
        {
            Console.WriteLine(String.Format("{0,-10}  {1,-10}  {2,10}", (userInput - userInputCalc + 1), squared(userInput - userInputCalc + 1), cubed(userInput - userInputCalc + 1)));
            
            userInputCalc--;
        }


        //ask user to continue

        Console.WriteLine("");
        Console.WriteLine("Continue? (y/n)");
        string userCont = Console.ReadLine();
        Console.WriteLine("");


        if (userCont == "n")
        {
            loop++;
        }
        else if (userCont == "y")
        {

        }
        //Recursive loop for entering invalid key
        else
        {
            int loop2 = 0;
            do
            {
                Console.WriteLine("Enter valid key");
                Console.WriteLine("");
                Console.WriteLine("Continue? (y/n)");
                string userCont2 = Console.ReadLine();
                Console.WriteLine("");

                if (userCont2 == "n")
                {
                    loop++;
                    loop2++;
                }
                else if (userCont2 == "y")
                {
                    loop2++;
                }

                else
                {
                    loop2 = 0;
                }

            }
            //Recursive loop ends
            while (loop2 == 0);




        }


    }
    //Limit number usage. No 0, negatives or > 1290 (limit of int)
    else if (userInput <= 0 || userInput >= 1291)
    {

        Console.WriteLine("Enter valid number");
        Console.WriteLine("");
        Console.WriteLine("Continue? (y/n)");
        string userCont2 = Console.ReadLine();
        Console.WriteLine("");
    }

    }

while (loop == 0);

//method square power
static int squared(int power)
{
    return power * power;
}

//method cubed power
static int cubed(int power)
{
    return power * power * power;
}