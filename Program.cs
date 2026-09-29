//Цикл-счетчик
int lessonNumber = 1;
int totalLesson = 5;

while (lessonNumber <= totalLesson) {
    Console.WriteLine($"Пара {totalLesson}");
    totalLesson -= 1 ;
}
Console.WriteLine("Пары закончились");

//Цикл с ограничителем
Console.WriteLine();
Console.WriteLine("Введите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
int count = 0;

while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
    count += 1;
}
Console.WriteLine("Ввод завершён");
Console.WriteLine($"Количество введеных оценок: {count}");

//Накопление суммы
Console.WriteLine();
int sum = 0;
int count1 = 0;
int max = 0;

Console.WriteLine("Вводите оценки, для завершение введите -1:");
int grade1 = int.Parse(Console.ReadLine());
if (grade1 != -1) {
    max = grade1;
}
while (grade1 != -1) {
    sum += grade1;
    count1++;
    
    if (grade1 > max){
        max = grade1;
    }
    grade1 = int.Parse(Console.ReadLine());
    
}

if (count1 > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count1}");
    Console.WriteLine($"Наибольшая оценка: {max}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}
//Бесконечный цикл и break
Console.WriteLine();
string correctPassword = "qwerty123";
int counter = 0;

while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        break;
    }
    if (password != correctPassword)
    {
        counter += 1;
    }
    Console.WriteLine("Неверный пароль, попробуйте снова");
}
Console.WriteLine($"Количество неудачных попыток: {counter}");
