namespace BlazorApp_empty2.Shared.Models;

public class Todo
{
    [JsonPropertyName(nameof(Id))]
    public int Id { get; set; }

    [JsonPropertyName(nameof(Title))]
    public string? Title { get; set; }

    [JsonPropertyName(nameof(IsCompleted))]
    public bool IsCompleted { get; set; }
}
