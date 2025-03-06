Console.WriteLine("Şifrenizi giriniz...");
string sifre = Console.ReadLine();

if (sifre.Length < 8) {
    Console.WriteLine("Şifreniz güçsüz. Şifreniz 8 karakterden kısa olamaz.");
} else if (!sifre.Any("@#&%*+-/?$".Contains)) {
    Console.WriteLine(
        "Şifreniz güçsüz. Şifreniz bu özel karakterlerden en az birini içermelidir. @, #, &, %, *, +, -, /, ?, $");
} else if (!sifre.Any(char.IsUpper)) {
    Console.WriteLine("Şifreniz güçsüz. Şifreniz en az 1 büyük harf içermelidir.");
} else {
    Console.WriteLine("Şifreniz güçlü.");
}