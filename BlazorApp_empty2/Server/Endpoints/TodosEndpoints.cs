namespace BlazorApp_empty2.Server.Endpoints;

public static class TodosEndpoints
{
    public static IEndpointRouteBuilder MapTodosEndpoints(this IEndpointRouteBuilder apiGroup)
    {
        var todoApiGroup = apiGroup.MapGroup("/todos");

        todoApiGroup.MapGet("/", GetAllTodosAsync);

        return apiGroup;
    }

    private static readonly List<Todo> todos = new()
    {
        new Todo { Id = 1, Title = "Do this thing.", IsCompleted = false },
        new Todo { Id = 2, Title = "Do that thing.", IsCompleted = true },
        new Todo { Id = 3, Title = "Do the other thing.", IsCompleted = false },
        new Todo { Id = 4, Title = "Do another thing.", IsCompleted = true },
        new Todo { Id = 5, Title = "Do yet another thing.", IsCompleted = false },
        new Todo { Id = 6, Title = "Do something else.", IsCompleted = true },
        new Todo { Id = 7, Title = "Do anything else.", IsCompleted = false },
        new Todo { Id = 8, Title = "Do everything else.", IsCompleted = true },
        new Todo { Id = 9, Title = "Do nothing.", IsCompleted = false },
        new Todo { Id = 10, Title = "Do something.", IsCompleted = true },
        new Todo { Id = 11, Title = "Do some stuff.", IsCompleted = false },
        new Todo { Id = 12, Title = "Do more stuff.", IsCompleted = true },
        new Todo { Id = 13, Title = "Do some more stuff.", IsCompleted = false },
        new Todo { Id = 14, Title = "Do even more stuff.", IsCompleted = true },
        new Todo { Id = 15, Title = "Do this thing again.", IsCompleted = false },
        new Todo { Id = 16, Title = "Do that thing again.", IsCompleted = true },
        new Todo { Id = 17, Title = "Do the other thing again.", IsCompleted = false },
        new Todo { Id = 18, Title = "Do another thing again.", IsCompleted = true },
        new Todo { Id = 19, Title = "Do yet another thing again.", IsCompleted = false },
        new Todo { Id = 20, Title = "Do something else again.", IsCompleted = true },
        new Todo { Id = 21, Title = "Do anything else again.", IsCompleted = false },
        new Todo { Id = 22, Title = "Do everything else again.", IsCompleted = true },
        new Todo { Id = 23, Title = "Do nothing again.", IsCompleted = false },
        new Todo { Id = 24, Title = "Do something again.", IsCompleted = true },
        new Todo { Id = 25, Title = "Do some stuff again.", IsCompleted = false },
        new Todo { Id = 26, Title = "Do more stuff again.", IsCompleted = true },
        new Todo { Id = 27, Title = "Do some more stuff again.", IsCompleted = false },
        new Todo { Id = 28, Title = "Do even more stuff again.", IsCompleted = true },
        new Todo { Id = 29, Title = "Do this thing once more.", IsCompleted = false },
        new Todo { Id = 30, Title = "Do that thing once more.", IsCompleted = true },
        new Todo { Id = 31, Title = "Do the other thing once more.", IsCompleted = false },
        new Todo { Id = 32, Title = "Do another thing once more.", IsCompleted = true },
        new Todo { Id = 33, Title = "Do yet another thing once more.", IsCompleted = false },
        new Todo { Id = 34, Title = "Do something else once more.", IsCompleted = true },
        new Todo { Id = 35, Title = "Do anything else once more.", IsCompleted = false },
        new Todo { Id = 36, Title = "Do everything else once more.", IsCompleted = true },
        new Todo { Id = 37, Title = "Do nothing once more.", IsCompleted = false },
        new Todo { Id = 38, Title = "Do something once more.", IsCompleted = true },
        new Todo { Id = 39, Title = "Do some stuff once more.", IsCompleted = false },
        new Todo { Id = 40, Title = "Do more stuff once more.", IsCompleted = true },
        new Todo { Id = 41, Title = "Do some more stuff once more.", IsCompleted = false },
        new Todo { Id = 42, Title = "Do even more stuff once more.", IsCompleted = true },
        new Todo { Id = 43, Title = "Do this thing one more time.", IsCompleted = false },
        new Todo { Id = 44, Title = "Do that thing one more time.", IsCompleted = true },
        new Todo { Id = 45, Title = "Do the other thing one more time.", IsCompleted = false },
        new Todo { Id = 46, Title = "Do another thing one more time.", IsCompleted = true },
        new Todo { Id = 47, Title = "Do yet another thing one more time.", IsCompleted = false },
        new Todo { Id = 48, Title = "Do something else one more time.", IsCompleted = true },
        new Todo { Id = 49, Title = "Do anything else one more time.", IsCompleted = false },
        new Todo { Id = 50, Title = "Do everything else one more time.", IsCompleted = true },
        new Todo { Id = 51, Title = "Do nothing one more time.", IsCompleted = false },
        new Todo { Id = 52, Title = "Do something one more time.", IsCompleted = true },
        new Todo { Id = 53, Title = "Do some stuff one more time.", IsCompleted = false },
        new Todo { Id = 54, Title = "Do more stuff one more time.", IsCompleted = true },
        new Todo { Id = 55, Title = "Do some more stuff one more time.", IsCompleted = false },
        new Todo { Id = 56, Title = "Do even more stuff one more time.", IsCompleted = true },
        new Todo { Id = 57, Title = "Do this thing twice more.", IsCompleted = false },
        new Todo { Id = 58, Title = "Do that thing twice more.", IsCompleted = true },
        new Todo { Id = 59, Title = "Do the other thing twice more.", IsCompleted = false },
        new Todo { Id = 60, Title = "Do another thing twice more.", IsCompleted = true },
        new Todo { Id = 61, Title = "Do yet another thing twice more.", IsCompleted = false },
        new Todo { Id = 62, Title = "Do something else twice more.", IsCompleted = true },
        new Todo { Id = 63, Title = "Do anything else twice more.", IsCompleted = false },
        new Todo { Id = 64, Title = "Do everything else twice more.", IsCompleted = true },
        new Todo { Id = 65, Title = "Do nothing twice more.", IsCompleted = false },
        new Todo { Id = 66, Title = "Do something twice more.", IsCompleted = true },
        new Todo { Id = 67, Title = "Do some stuff twice more.", IsCompleted = false },
        new Todo { Id = 68, Title = "Do more stuff twice more.", IsCompleted = true },
        new Todo { Id = 69, Title = "Do some more stuff twice more.", IsCompleted = false },
        new Todo { Id = 70, Title = "Do even more stuff twice more.", IsCompleted = true },
        new Todo { Id = 71, Title = "Do this thing three times more.", IsCompleted = false },
        new Todo { Id = 72, Title = "Do that thing three times more.", IsCompleted = true },
        new Todo { Id = 73, Title = "Do the other thing three times more.", IsCompleted = false },
        new Todo { Id = 74, Title = "Do another thing three times more.", IsCompleted = true },
        new Todo { Id = 75, Title = "Do yet another thing three times more.", IsCompleted = false },
        new Todo { Id = 76, Title = "Do something else three times more.", IsCompleted = true },
        new Todo { Id = 77, Title = "Do anything else three times more.", IsCompleted = false },
        new Todo { Id = 78, Title = "Do everything else three times more.", IsCompleted = true },
        new Todo { Id = 79, Title = "Do nothing three times more.", IsCompleted = false },
        new Todo { Id = 80, Title = "Do something three times more.", IsCompleted = true },
        new Todo { Id = 81, Title = "Do some stuff three times more.", IsCompleted = false },
        new Todo { Id = 82, Title = "Do more stuff three times more.", IsCompleted = true },
        new Todo { Id = 83, Title = "Do some more stuff three times more.", IsCompleted = false },
        new Todo { Id = 84, Title = "Do even more stuff three times more.", IsCompleted = true },
        new Todo { Id = 85, Title = "Do this thing four times more.", IsCompleted = false },
        new Todo { Id = 86, Title = "Do that thing four times more.", IsCompleted = true },
        new Todo { Id = 87, Title = "Do the other thing four times more.", IsCompleted = false },
        new Todo { Id = 88, Title = "Do another thing four times more.", IsCompleted = true },
        new Todo { Id = 89, Title = "Do yet another thing four times more.", IsCompleted = false },
        new Todo { Id = 90, Title = "Do something else four times more.", IsCompleted = true },
        new Todo { Id = 91, Title = "Do anything else four times more.", IsCompleted = false },
        new Todo { Id = 92, Title = "Do everything else four times more.", IsCompleted = true },
        new Todo { Id = 93, Title = "Do nothing four times more.", IsCompleted = false },
        new Todo { Id = 94, Title = "Do something four times more.", IsCompleted = true },
        new Todo { Id = 95, Title = "Do some stuff four times more.", IsCompleted = false },
        new Todo { Id = 96, Title = "Do more stuff four times more.", IsCompleted = true },
        new Todo { Id = 97, Title = "Do some more stuff four times more.", IsCompleted = false },
        new Todo { Id = 98, Title = "Do even more stuff four times more.", IsCompleted = true },
        new Todo { Id = 99, Title = "Almost done.", IsCompleted = true },
        new Todo { Id = 100, Title = "The final todo.", IsCompleted = true },
    };

    private static async IAsyncEnumerable<Todo> GetAllTodosAsync()
    {
        foreach (var todo in todos.Take(10))
        {
            yield return todo;
            await Task.Delay(100);
        }
    }
}
