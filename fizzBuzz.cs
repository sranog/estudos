
int[] numeros = Enumerable.Range(1, 100).ToArray();


for (int i = 0; i < numeros.Length; i++)
{
	string fizzBuzz = "";
	
	if (numeros[i] % 3 == 0 && numeros[i] % 5 == 0)
	{ 
		fizzBuzz = "fizzbuzz";
	}
	else if (numeros[i] % 3 == 0)
	{
		fizzBuzz = "fizz";
	}
		else if (numeros[i] % 5 == 0)
		{
			fizzBuzz = "buzz";
		}
		else
		{
			Console.WriteLine($"{numeros[i]} {fizzBuzz}");
		}
	}

