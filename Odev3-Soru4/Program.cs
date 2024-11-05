// See https://aka.ms/new-console-template for more information

int b = 1;
int a = 1;
int sonuc = 0;
Console.WriteLine("Bir sayı giriniz");
int say = int.Parse(Console.ReadLine());
for (int i = 0; i < say; i++)
{
    Console.Write(sonuc+ " ");
    a = b;
    b = sonuc;
    sonuc = a + b;
    
}
