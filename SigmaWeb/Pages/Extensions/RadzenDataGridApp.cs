using Radzen.Blazor;

namespace SigmaWeb.Pages.Extensions
{
    public class RadzenDataGridApp<TItem> : RadzenDataGrid<TItem>
    {
        public RadzenDataGridApp() : base()
        {
            base.ContainsText = "Contém";
            base.PageSizeText = "Itens por página";
            base.EqualsText = "Igual ao texto";
            base.NotEqualsText = "Diferente do texto";
            base.StartsWithText = "Começa com";
            base.EndsWithText = "Termina com";
            base.IsNotEmptyText = "Não nulo ou vazio";
            base.DoesNotContainText = "Não contém texto";
            base.IsNotNullText = "Não nulo";
            base.OrOperatorText = "Ou";
            base.GreaterThanOrEqualsText = "Maior que ou igual";
            base.AndOperatorText = "E";
            base.IsNullText = "É Nulo";
            base.FilterText = "Filtros";
            base.IsEmptyText = "Está vazio.";
            base.ClearFilterText = "Limpar";
            base.ApplyFilterText = "Aplicar";
            base.EmptyText = "Nenhum registro a ser exibido";
            base.PagingSummaryFormat = $"Página" + " {0} " + $"de" + " {1} ({2} " + $"Itens)";
        }
    }
}
