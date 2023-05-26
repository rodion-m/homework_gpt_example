using System;

// Получаем текущую дату
DateTime currentDate = DateTime.Today;

// Получаем дату Нового года для следующего года
DateTime nextYear = new DateTime(currentDate.Year + 1, 1, 1);

// Вычисляем разницу в днях
int daysRemaining = (nextYear - currentDate).Days;

// Выводим результат
Console.WriteLine("До Нового года осталось {0} дней.", daysRemaining);

// Чтобы консольное окно не закрылось сразу после вывода результата
Console.ReadLine();
