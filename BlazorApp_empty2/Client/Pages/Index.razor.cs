namespace BlazorApp_empty2.Client.Pages;

public partial class Index
{
    private async Task GetAllTodosAsync()
    {
        await TodosService.GetAllTodosAsync();
    }
}
