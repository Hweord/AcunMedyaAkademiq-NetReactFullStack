Console.WriteLine("Yapmak istediğiniz işlemi seçiniz... (+, -, *, /)");
char islem = Console.ReadKey().KeyChar;

Console.WriteLine("İşlem yapılacak birinci sayıyı giriniz.");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İşlem yapılacak ikinci sayıyı giriniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int sonuc = 0;

switch (islem) {
    case '+':
        sonuc = sayi1 + sayi2;
        break;
    case '-':
        sonuc = sayi1 - sayi2;
        break;
    case '*':
        sonuc = sayi1 * sayi2;
        break;
    case '/':
        if (sayi2 == 0) {
            Console.WriteLine("İşlem hatası. Hiçbir sayı sıfıra bölünemez.");
            break;
        } else
            sonuc = sayi1 / sayi2;
        break;
    default:
        Console.WriteLine("İşlem hatası. Geçersiz işlem seçimi.");
        break;
}

Console.WriteLine("Sonuç: " + sonuc);