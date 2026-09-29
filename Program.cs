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

