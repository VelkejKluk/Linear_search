Random random = new Random();

int[] vyskaLidi = new int[50];

for (int i = 0; i < vyskaLidi.Length; i++)
{
    vyskaLidi[i] = random.Next(40, 220);
}

int posledniPrvekPole = vyskaLidi.Length - 1;

//hledá výšku
Console.Write("Chci najít člověka s výškou: ");
int input = Convert.ToInt32(Console.ReadLine());

if (!vyskaLidi.Contains(input))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("nenalezeno");
    Console.ResetColor();
    return;
}
for(int i = 0; i < posledniPrvekPole; i++)
{
    if (input == vyskaLidi[i])
    {   
        if (input >= 160)
        {
            Console.WriteLine($"Osobě je {random.Next(18, 80)} let");
            Console.WriteLine("Je to dospělý");

        }
        else
        {
            Console.WriteLine($"Osobě je {random.Next(3, 17)} let");
            Console.WriteLine("Je to dítě");
        }
        
    }
}