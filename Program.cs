class Program
{
    static bool error = false; // переменная ошибки
    static void Main() // точка входа
    {
        double y, k, x, b, lower_limit, upper_limit, step_value; // значения формулы
        Console.WriteLine("Добро пожаловать в программу для вычисления значений математических функций!"); // приветсвие
        do // выполнение программы единожды
        {
            error = false; // см. строку № 34
            try // проверка на ноличие ошибок
            {
                Console.WriteLine("Введите значение k формулы, Если k отсутствует введите 1.");
                k = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Введите значение b формулы, Если b отсутствует введите 0.");
                b = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Введите нижний лимит значений x.");
                lower_limit = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Введите верхний лимит значений x.");
                upper_limit = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Введите величину шага для значений x.");
                step_value = Math.Abs(double.Parse(Console.ReadLine()!)); // Math.Abs для получения модуля исходного числа
                x = lower_limit;
                Console.WriteLine($"При k={k} и b={b} Функция y=kx+b равна:");
                for (; x <= upper_limit; x += step_value) // вывод "y" во всех значениях
                {
                    y = k * x + b; // непосредственно мат. выражение
                    Console.WriteLine($"При x={x} y={y}"); // $ для интерполяции строк
                }
            }
            catch (Exception) // проверка на ошибку "Exception" для недопущения ввода некорректных данных
            {
                Console.WriteLine("Неверная запись значений, Перезапуск.");
                error = true; // здесь переменная исполнения получает значение "true"
            }
        }
        while (error); // если программа завершилась без ошибок то она завершит работу, если нет то полностью перезапустится
        Console.WriteLine("Нажмите любую клавишу для продолжения");
        Console.ReadKey(); // ожидание нажатия
    }
}