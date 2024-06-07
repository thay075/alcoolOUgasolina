using System.Runtime.CompilerServices;

double etanol, gasolina, Calculo = 0;
double porce = 0;

Console.WriteLine(@"/////  Preço da Gasolina e do Alcool  \\\\\");

Console.WriteLine("Preço do Etanol...: ");
etanol = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Preço do Gasolina...: ");
gasolina = Convert.ToDouble(Console.ReadLine());

void precotras(){
    Calculo = etanol / gasolina;
    
}

precotras();

void porcen(){
    porce = Calculo * 100;
}

porcen();

if(Calculo > 0.73){
    Console.WriteLine($"O preço do etanol corresponde a {porce}% do preço da gasolina.");
    Console.WriteLine("Gasolina Está Mais Em Conta");
}

else if(Calculo < 0.73){
    Console.WriteLine($"O preço do etanol corresponde a {porce}% do preço da gasolina.");
    Console.WriteLine("Etanol Está Mais Em Conta");
}