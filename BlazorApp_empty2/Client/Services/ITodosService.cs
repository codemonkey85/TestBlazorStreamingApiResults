namespace BlazorApp_empty2.Client.Services;

public interface ITodosService
{
    IAsyncEnumerable<Todo> GetAllTodosAsync();
}
