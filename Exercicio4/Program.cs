// See https://aka.ms/new-console-template for more information
double faturamentoSP = 67836.43;
double faturamentoRJ = 366788.43;
double faturamentoMG = 29229.88;
double faturamentoES = 27165.48;
double faturamentoOutros = 19849.53;
double faturamentoTotal = faturamentoES + faturamentoMG + faturamentoOutros + faturamentoRJ + faturamentoSP;

Console.WriteLine($"Percentual dos estados:\n" +
                  $"SP : {(faturamentoSP / faturamentoTotal) * 100:F2}\n" +
                  $"RJ : {(faturamentoRJ / faturamentoTotal) * 100:F2}\n" +
                  $"MG : {(faturamentoMG / faturamentoTotal) * 100:F2}\n" +
                  $"ES : {(faturamentoES / faturamentoTotal) * 100:F2}\n" +
                  $"Outros : {(faturamentoOutros / faturamentoTotal) * 100:F2}%");
