Console.Write("Lütfen bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

//Girilen sayının 10'dan büyük mü küçük mü veya eşit mi kontrolünün yapıldığı kod bloğu
if (sayi > 10) Console.WriteLine("Girilen sayi 10'dan büyüktür");
else if (sayi == 10) Console.WriteLine("Girilen sayi 10'a esittir");
else Console.WriteLine("Girilen sayi 10'dan kücüktür");

//Girilen sayının tek mi çift mi olduğunun kontrolünün yapıldığı kod bloğu
if (sayi % 2 == 0) Console.WriteLine("Girilen sayi cifttir");
else Console.WriteLine("Girilen sayi tektir");
