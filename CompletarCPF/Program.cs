Console.WriteLine("Digite 11 dígitos:");
string cpf = Console.ReadLine();
Console.WriteLine(GerarCpf(cpf));

 static string GerarCpf(string cpf)
{
    int d1=0;
    int d2=0;
    int cont = 10;

    for (int i = 0; i <= 8; i++)
        d1 += (cpf[i]-'0') * cont--;

    d1 = (d1 % 11 < 2) ? 0 : 11 - (d1 % 11);


    cpf += d1.ToString();
    cont = 11;
    for (int i = 0; i <= 9; i++)
        d2 += (cpf[i]-'0') * cont--;
    
    d2 = (d2 % 11 < 2) ? 0 : 11 - (d2 % 11);


    cpf += d2.ToString();
    return cpf;
}
// 012345678
