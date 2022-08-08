Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень B: ");
int B = Convert.ToInt32(Console.ReadLine());
int stepen = A;
for (int i=1; i<B; i++){
    stepen = stepen*A;
}
Console.WriteLine(" Итоговый результат: " + stepen);
