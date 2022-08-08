int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++){
    Console.Write($"Введите элемент данного массива: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Данный массив: [" + string.Join(", ", arr) + "]");
