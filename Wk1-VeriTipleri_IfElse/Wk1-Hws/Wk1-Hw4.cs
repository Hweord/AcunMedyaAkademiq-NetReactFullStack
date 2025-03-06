Console.WriteLine("1. sayıyı giriniz...");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. sayıyı giriniz...");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3. sayıyı giriniz...");
int sayi3 = Convert.ToInt32(Console.ReadLine());

if (sayi2 > sayi1) {
	int temp = sayi1;
	sayi1 = sayi2;
	sayi2 = temp;
}

if (sayi3 > sayi1) {
	int temp = sayi1;
	sayi1 = sayi3;
	sayi3 = temp;
}

if (sayi3 > sayi2) {
	int temp = sayi2;
	sayi2 = sayi3;
	sayi3 = temp;
}

Console.WriteLine("Büyükten küçüğe sıralanmış hali: " + sayi1 + " " + sayi2 + " " + sayi3);
Console.WriteLine("En büyük sayı: " + sayi1);