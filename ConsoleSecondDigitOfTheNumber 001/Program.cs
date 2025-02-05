namespace ConsoleSecondDigitOfTheNumber_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Считываем число n
			int n;

			while (true) // Начинаем бесконечный цикл
			{
				//Console.WriteLine("Введите число:");
				if (int.TryParse(GetInput(), out n))
				{
					n = CalculateSecondLastDigit(n);
					Console.ReadKey();
					// Завершаем программу после корректного ввода
					return; // Выходим из метода Main, завершив программу
				}
				else
				{
					Console.WriteLine("Ошибка: введено некорректное число. Пожалуйста, попробуйте снова.");
				}
			}
		}

		/// <summary>
		/// Вычисляет вторую цифру числа.
		/// </summary>
		/// <param name="number">Число, из которого нужно получить вторую цифру.</param>
		/// <returns>Вторая цифра числа.</returns>
		private static int CalculateSecondLastDigit(int n)
		{
			// Уменьшаем n, пока оно больше 99
			while (n > 99)
			{
				n /= 10; // Делим на 10
			}

			// Выводим последнюю цифру n
			Console.WriteLine("Последняя цифра: " + (n % 10));
			return n;
		}

		/// <summary>
		/// Запрашивает у пользователя ввод трёхзначного числа.
		/// </summary>
		/// <returns>Строку, введённую пользователем.</returns>
		static string? GetInput()
		{
			Console.WriteLine("Введите трёхзначное число:");
			return Console.ReadLine();
		}
	}
}
