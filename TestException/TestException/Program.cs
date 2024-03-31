using TestException;

try
{
    Console.WriteLine("enter age: ");
    string age;
    age = Console.ReadLine();
    if (Int32.TryParse(age, out int ageInt))
    {
        Console.WriteLine($"age:{ageInt}");
    }
    else
    {
        throw new NumberException(age);
    }

    string score;
    Console.WriteLine("enter score:");
    score = Console.ReadLine();
    if (float.TryParse(score, out float scoreFloat))
    {
        Console.WriteLine($"score: {scoreFloat}");
    }
    else
    {
        throw new FloatException(score);
    }
}
catch (NumberException e)
{
    Console.WriteLine(e.Message);
}
catch (FloatException e)
{
    Console.WriteLine(e.Message);
}