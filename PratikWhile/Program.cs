
using System;

int i = 0;

while (i < 10)
{
    Console.WriteLine($"Kendime inanıyorum, ben bu yazılım işini hallederim!");

    i++;
}

int a = 1;

while (a < 20)
{
    Console.WriteLine(a);

    a++;

}



int b = 1;
while (b < 20)
{

    if (b % 2 == 0)
    {
        Console.WriteLine(b);
    }
    b++;
}


int toplam = 0; 
int sayi = 50;
while (sayi <= 150)
{
    toplam += sayi;
    sayi++;
}

Console.WriteLine("50 ile 150 arasındaki sayıların toplamı = " + toplam);


int c = 0;
int cift_toplam = 0;
int tek_toplam = 0;
while (c <= 120)
{
    if (c % 2 == 0)
    {
        cift_toplam += c;
    }
    else
    {
        tek_toplam += c;
    }
    c++;
}
Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı : {cift_toplam}");
Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı : {tek_toplam}");