WriteLine("Bir sayı giriniz...");
int sayi = Convert.ToInt32(ReadLine());

if (sayi == 0) {
    WriteLine("Bu sayı sıfırdır.");
} else if (sayi > 0) {
    WriteLine("Sayı pozitiftir.");
} else {
    WriteLine("Sayı negatiftir.");
}