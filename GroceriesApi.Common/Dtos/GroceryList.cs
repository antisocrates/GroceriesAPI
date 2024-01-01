namespace GroceriesApi.Common;

public readonly record struct GroceryList
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
}
