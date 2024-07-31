
static void Sum(int a, int b)
{
    int sum = a + b;
    Console.WriteLine(sum);
}

Sum(12,25);



//Polindrom number

static string PolindromNumber(int number)
{
    int reverseNumber = 0;
    int num = number;
    while (num>0)
    {
        reverseNumber = reverseNumber*10 + num%10;
        num= num/10;
    }
    if (reverseNumber == number)
    {
        return "Is polindrom";
    }
    else
    {
        return "Is't polindrom";
    }
}

Console.WriteLine(PolindromNumber(545));


//Two sum
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.


int[] nums = [2, 5, 11, 7];
int target = 9;

for (int i = 0; i < nums.Length; i++)
{
    for (int j = i+1; j < nums.Length;  j++)
    {
        if (nums[i]+nums[j]==target)
        {
            Console.WriteLine("["+i+","+j+"]");
        }
    }
}


static string Login(string user, string password)
{
    if (user == "nihatss" && password == "niko123")
    {
        return "Successfull login!";
    }
    else
    {
        Console.WriteLine();
        return "Wrong user or password!";
    }
}

string userName = "nihatss";
string password = "nihat123";

Console.WriteLine(Login(userName, password));