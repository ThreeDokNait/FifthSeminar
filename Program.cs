Console.Clear();


// task 1

// int[] array = new int[12];

// int sumNegNum = 0;
// int sumPosNum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     System.Console.WriteLine(array[i]+ " ");
//     if (array[i] > 0)
//     {
//         sumNegNum = sumNegNum + array[i];
//     }
//     else
//     {
//         sumPosNum = sumPosNum + array[i];
//     }
// }

// System.Console.WriteLine($"сумма положительных = {sumPosNum}, Сумма отрицательных = {sumNegNum}");


// task 2

// int[] array = new int[4];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     System.Console.Write(array[i]+ ", ");
// }
// System.Console.WriteLine();
// while (count<array.Length)
// {
//     array[count] = array [count] * -1;
//     System.Console.WriteLine(array [count] + " ");
//     count++;
// }


// Task 3

// int[] array = new int[5];
// System.Console.WriteLine("введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// bool numF = false;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 6);
//     System.Console.Write(array[i]+ ", ");
//     if (array[i]== num)
// {
//     numF = true;
// }
// }
// if (numF== true)
// {
//     System.Console.WriteLine("Yes");
// }
// else
// {
//     System.Console.WriteLine("No");
// }
// System.Console.WriteLine();


// Task 3

// int[] array = new int[139];

// int count =0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 140);
//     System.Console.Write(array[i]+ ", ");

//     if (array[i]>9 && array[i]<100)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine("Count = " + count);


// Task 4

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array1 = new int[num];
// int[] array2 = new int[array1.Length / 2 + array1.Length % 2];

// for (int i = 0; i < array1.Length; i++)
// {
//     array1[i] = new Random().Next(0, 9);
//     System.Console.Write(array1[i] + ", ");

// }
// System.Console.WriteLine();
// for (int i = 0; i < array2.Length; i++)
// {
//     array2[i] = array1[i] * array1[array1.Length - 1 - i];
//     if (i == array1.Length - 1 - i)
//     {
//         array2[i] = array1[i];
//     }
//     System.Console.Write(array2[i] + " ");
// }