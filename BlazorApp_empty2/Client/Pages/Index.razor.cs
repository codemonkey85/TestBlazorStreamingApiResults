namespace BlazorApp_empty2.Client.Pages;

public partial class Index
{
    private readonly List<Todo> _todos = new();

    private async Task GetAllTodosAsync()
    {
        await foreach (var todo in TodosService.GetAllTodosAsync())
        {
            _todos.Add(todo);
            StateHasChanged();
        }
    }
}
