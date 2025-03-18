using PairOdev;

class Program
{
    static void Main()
    {
        IndividualCustomerManager customerManager = new IndividualCustomerManager();

        // Yeni müşteriler ekleyelim
        customerManager.Add(new IndividualCustomer { Id = 1, FirstName = "Yakup", LastName = "Arıevi", PhoneNumber = "05551112233" });
        customerManager.Add(new IndividualCustomer { Id = 2, FirstName = "Yunus", LastName = "Çakır", PhoneNumber = "05443334455" });
        customerManager.Add(new IndividualCustomer { Id = 3, FirstName = "Muhammed", LastName = "İnan", PhoneNumber = "05441554455" });


        // Müşteri listesini alalım
        Console.WriteLine("\nMüşteri Listesi:");
        foreach (var customer in customerManager.GetList())
        {
            Console.WriteLine($"ID: {customer.Id}, Ad: {customer.FirstName}, Soyad: {customer.LastName}, Telefon: {customer.PhoneNumber}");
        }

        // Belirli bir müşteriyi ID'ye göre getirelim
        var foundCustomer = customerManager.GetById(1);
        if (foundCustomer != null)
        {
            Console.WriteLine($"\nID 1 olan müşteri: {foundCustomer.FirstName} {foundCustomer.LastName}, Telefon: {foundCustomer.PhoneNumber}");
        }

        // Müşteriyi silelim
        customerManager.Delete(1);

        // Güncel listeyi tekrar yazdıralım
        Console.WriteLine("\nGüncellenmiş Müşteri Listesi:");
        foreach (var customer in customerManager.GetList())
        {
            Console.WriteLine($"ID: {customer.Id}, Ad: {customer.FirstName}, Soyad: {customer.LastName}, Telefon: {customer.PhoneNumber}");
        }
    }
}