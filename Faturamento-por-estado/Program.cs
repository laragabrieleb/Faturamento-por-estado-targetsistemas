using Faturamento_por_estado;
using System.Globalization;

List<FaturamentoMensal> faturamentosMensais = new()
{
    new FaturamentoMensal() { Estado = "SP", Valor = 67836.43 },
    new FaturamentoMensal() { Estado = "RJ", Valor = 36678.66 },
    new FaturamentoMensal() { Estado = "MG", Valor = 29229.88 },
    new FaturamentoMensal() { Estado = "ES", Valor = 27165.48 },
    new FaturamentoMensal() { Estado = "Outros", Valor = 19849.53 }
};

//calcular e armazenar o total de faturamento (todos os estados) - valor total mensal arrecadado pela distribuidora
double valorTotal = faturamentosMensais.Sum(x => x.Valor);

//para cada item da lista faturamentoMensais, calcular o percentual com base no valor total
foreach (var item in faturamentosMensais)
{
   double percentual = (item.Valor/ valorTotal) * 100;
   Console.WriteLine("Estado: " + item.Estado + " Valor: R$" + item.Valor.ToString("F2", CultureInfo.CurrentCulture) + " Percentual: " + percentual.ToString("F2") + "%");
}

Console.WriteLine("Valor total mensal arrecadado pela distribuidora: R$ " + valorTotal.ToString("F2", CultureInfo.CurrentCulture));

Console.ReadLine();
