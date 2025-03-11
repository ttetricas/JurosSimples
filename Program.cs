decimal c = 1200m, i = 2m;// capital inicial e taxa de juros 
int t = 15;// tempo 

decimal j = (c * i * t) / 100;
decimal m = c + j;

Console.WriteLine($"Juros: R$ {j} \nMontante: R$ {m}");
