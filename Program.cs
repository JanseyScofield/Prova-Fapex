using Prova;
using Prova.CoresPrimarias;



Cor cor1 = new Cor(new Red(37), new Green(150), new Blue(190));
Cor cor2 = new Cor(new Red(256));
Cor cor3 = new Cor();



Console.WriteLine(cor1);
Console.WriteLine(Cor.CodigoCor(cor1));

Console.WriteLine(cor2);
Console.WriteLine(Cor.CodigoCor(cor2));

Console.WriteLine(cor3);
Console.WriteLine(Cor.CodigoCor(cor3));

Console.WriteLine(Cor.CheckCor(cor1, cor2));


Cor cinzaCor1 = Cor.CinzaCor(cor1);

Console.WriteLine(cinzaCor1);
Console.WriteLine(Cor.CodigoCor(cinzaCor1));

Cor clarearCor1 = Cor.Clarear(cor1, 0.1);

Console.WriteLine(clarearCor1);
Console.WriteLine(Cor.CodigoCor(clarearCor1));

Cor escurecerCor1 = Cor.Escurecer(cor1, 0.1);

Console.WriteLine(escurecerCor1);
Console.WriteLine(Cor.CodigoCor(escurecerCor1));

Cor corRGB = Cor.TipoRGB("797979");
Console.WriteLine(corRGB);
