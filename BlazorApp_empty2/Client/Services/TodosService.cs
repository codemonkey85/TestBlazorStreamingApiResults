namespace BlazorApp_empty2.Client.Services;

public record TodosService(HttpClient HttpClient) : ITodosService
{
    private const string BaseUrl = "api/todos";

    public List<Todo> Todos { get; set; } = new();

    public async Task GetAllTodosAsync()
    {
        Todos.Clear();

        using var response = await HttpClient.GetAsync(BaseUrl);
        response.EnsureSuccessStatusCode();

        using var stream = await response.Content.ReadAsStreamAsync();

        await foreach (var todo in JsonSerializer.DeserializeAsyncEnumerable<Todo>(stream))
        {
            if (todo is null)
            {
                continue;
            }

            Console.WriteLine(todo.Title);
            Todos.Add(todo);
            await Task.Delay(100);
        }
    }
}
