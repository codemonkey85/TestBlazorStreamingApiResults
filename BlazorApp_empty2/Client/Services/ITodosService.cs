namespace BlazorApp_empty2.Client.Services;

public interface ITodosService
{
    List<Todo> Todos { get; set; }

    Task GetAllTodosAsync();
}
