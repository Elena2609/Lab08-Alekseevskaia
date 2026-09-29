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

//Знакомство с do-while
Console.WriteLine();
string answer;

do
{
    Console.Write("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.Write("Добавить еще одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");

Console.WriteLine("Дневник сохранён");

//Самостоятельные задания 
Console.WriteLine();
Console.WriteLine("Задача А");
int N1 = 7;
int i1 = 1;
while (i1 <= 10)
{
    Console.WriteLine($"{N1} * {i1} = {N1 * i1}");
    i1++;
}

Console.WriteLine();
Console.WriteLine("Задача Б");
Console.WriteLine("Вводите имена учеников, для завершения введите слово конец: ");
string name = Console.ReadLine();
int count0 = 0;
while (name != "конец") {
    count0 += 1;
    name = Console.ReadLine();
}
Console.WriteLine($"Количество имён: {count0}");

//Индивидуальный вариант
Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

Console.WriteLine();
Console.WriteLine("Вариант 1");
int N = 5;
int i = 1;
while (i <= N) {
    Console.WriteLine(N);
    N -= 1;
}
Console.WriteLine("Старт!");

Console.WriteLine();
Console.WriteLine("Вариант 2");
Console.WriteLine("Вводите целые числа, для завершения введите 0");
int num = int.Parse(Console.ReadLine());
int summ = 0;

while (num != 0) {
    if (num > 0) {
    summ += num;
}
    num = int.Parse(Console.ReadLine());
} 

Console.WriteLine($"Сумма положительных чисел = {summ}");

//Дополнительное задание. Банкомат
Console.WriteLine();
string correctsPassword = "1234";
int limiter = 0;
bool successfull = false;
while (limiter < 3 && !successfull) {
    limiter++;
    Console.Write("Введите PIN-код:");
    string passwords = Console.ReadLine();

    if (passwords == correctsPassword) {
        successfull = true;
        Console.WriteLine("Доступ разрешен");
    } else {
        Console.WriteLine("Неверный PIN-код");
    }
}
if (!successfull) {
    Console.WriteLine("Карта заблокирована");
} else {
    int total_amount = 0;
    Console.WriteLine("Введите суммы для снятия, чтобы завершить введите 0");
    int amount = int.Parse(Console.ReadLine());
    while (amount != 0){
        if (amount > 0){
            total_amount += amount;
        } else {
            Console.WriteLine("Сумма должна быть положительной");
        }
        amount = int.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Итоговая снятая сумма: {total_amount} руб.");
}
