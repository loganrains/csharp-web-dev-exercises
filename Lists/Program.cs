//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

Console.WriteLine("Hello, Lists!");

List<int> nums = new List<int> {1, 2, 3, 4, 6, 10, 19, 25, 30, 32};

List<string> words = new List<string> {"Donkey", "Banana", "Coal", "Human", "Rocket", "Spider", "Five", "Treat"};


static int sumEvens(List<int> nums)
{
    int sum = 0;
    foreach(int num in nums)
    {
        if(num % 2 == 0)
        {
            sum += num;
        }
    }
    return sum;
}

static void printFives(List<string> words)
{
    Console.WriteLine("Hello User, please enter how many characters your word has.");
    int numChar = int.Parse(Console.ReadLine());
    foreach(string word in words)
    {
        if(word.Length == numChar)
        {
            Console.WriteLine(word);
        }
    }
}

// int sums = sumEvens(nums);
// Console.WriteLine(sums);

printFives(words);

