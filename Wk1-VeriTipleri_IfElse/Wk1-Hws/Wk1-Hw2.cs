Console.WriteLine("İlgili günün kaçıncı gün olduğunu giriniz (1-7 arasında):");
int gun = Convert.ToInt32(Console.ReadLine());

switch (gun) {
	case 1:
		Console.WriteLine("Girdiğiniz gün Pazartesi.");
		break;

	case 2:
		Console.WriteLine("Girdiğiniz gün Salı.");
		break;

	case 3:
		Console.WriteLine("Girdiğiniz gün Çarşamba.");
		break;

	case 4:
		Console.WriteLine("Girdiğiniz gün Perşembe.");
		break;

	case 5:
		Console.WriteLine("Girdiğiniz gün Cuma.");
		break;

	case 6:
		Console.WriteLine("Girdiğiniz gün Cumartesi.");
		break;

	case 7:
		Console.WriteLine("Girdiğiniz gün Pazar.");
		break;

	default:
		Console.WriteLine("Gün bilgisi hatalı. Lütfen 1 ile 7 arasında bir sayı giriniz.");
		break;
}