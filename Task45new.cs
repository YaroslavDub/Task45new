// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите кол-во элементов массива");
int i = Convert.ToInt32(Console.ReadLine());
int [] array1 = new int [i];
int [] array2 = new int [i];
for (int count = 0; count < i; count++) {
    array1[count] = new Random().Next(1, 11);
}
for (int count = 0; count < i; count++) {
    array2[count] = array1[count];
}
Console.WriteLine(string.Join(" ", array1));
Console.WriteLine("Копия массива ---->"+ string.Join(" ", array2));
