// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная №13");
//     Console.WriteLine("0_0");
// }

// void PrintFooter(){
//     Console.WriteLine(">_<");
//     Console.WriteLine("  Конец программы");
//     Console.WriteLine("X_X");
// }
// void PrintStudentCard(string name, int age, string group) {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
//     Console.WriteLine("Дата формирования отчёта");
// }

// PrintStudentCard("Егор", 18, "ИВТ-21");
// PrintStudentCard("Валерия", 17, "ПИ-22");

// void PrintStudentCard(string name, int age)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}");
// }
// bool IsEligibleForBonus(double averageGrade) {
//     return averageGrade >= 4.5;
// }

// double baseAmount = 2000;
// double averageGrade = 4.6;

// if (IsEligibleForBonus(averageGrade)) {
//     double result = CalculateScholarship(baseAmount, 15);
//     Console.WriteLine(result);
// } else {
//     Console.WriteLine(baseAmount);
// }

// int CountFives(int grades) {
//     int count = 0;
//     foreach (int grade in grades) {
//         if (grade == 5) count++;
//     }
//     return count;
// }

// int grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// int fivesCount = CountFives(grades);
// Console.WriteLine($"Средний балл: {average}, количество пятёрок: {fivesCount}");

// //zad
// void PrintDivider() {
//     Console.WriteLine("------------------------");
// }

// void PrintPerson(string name, int age) {
//     Console.WriteLine(\$"Имя: {name}, возраст: {age}");
// }

// PrintDivider();
// PrintPerson("Анна", 25);
// PrintDivider();
// PrintPerson("Борис", 30);
// PrintDivider();
// PrintPerson("Виктор", 22);
// PrintDivider();

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// var 5 and 7

// double CalculateBmi(double weight, double heightMeters) {
//     return weight / (heightMeters * heightMeters);
// }

// double weight = 70.5;
// double height = 1.75;
// double bmi = CalculateBmi(weight, height);
// Console.WriteLine($"Индекс массы тела: {bmi:F2}");

// int FindMin(int[] numbers)
// {
//     int min = numbers[0];
//     foreach (int n in numbers)
//     {
//         if (n < min) min = n;
//     }
//     return min;
// }

// int[] arr = { 5, 3, 8, 1, 9, 2 };
// int result = FindMin(arr);
// System.Console.WriteLine("Минимум: " + result);