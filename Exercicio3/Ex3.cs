using Newtonsoft.Json;

string jsonFilePath = "faturamentoDiario.json";

// Ler o arquivo JSON
//CAMINHO DO ARQUIVO JSON: bin/Debug/net8.0/faturamentoDiario.json
string jsonData = File.ReadAllText(jsonFilePath);

// Deserializar os dados JSON
dynamic faturamentoData = JsonConvert.DeserializeObject(jsonData);

double[] faturamentoDiario = new double[31];
double mediaMensal = 0;
int diaVetor = 0;
int diaMaiorMensal = 0;

foreach (var dia in faturamentoData.faturamento)
{
    double valor = dia.valor;
    faturamentoDiario[diaVetor] = valor;
    diaVetor++;
}
double menorValorDia = faturamentoDiario[0];
double maiorValorDia = faturamentoDiario[0];

for (int i = 0; i < faturamentoDiario.Length; i++)
{
    if (faturamentoDiario[i] < menorValorDia)
        menorValorDia = faturamentoDiario[i];
    if (faturamentoDiario[i] > maiorValorDia)
        maiorValorDia = faturamentoDiario[i];
    mediaMensal += faturamentoDiario[i];
}
mediaMensal /= 31;

for(int i = 0; i < faturamentoDiario.Length; i++)
{
    if (faturamentoDiario[i] > mediaMensal)
    {
        diaMaiorMensal += 1;
    }
}

Console.WriteLine($"O menor valor de faturamento ocorrido em um dia do mês foi de :{menorValorDia} Reais");
Console.WriteLine($"O maior valor de faturamento ocorrido em um dia do mês foi de :{maiorValorDia} Reais");
Console.WriteLine($"O número de dias do mês que o valor de faturamento diario foi superior à média mensal :{diaMaiorMensal} dias");


