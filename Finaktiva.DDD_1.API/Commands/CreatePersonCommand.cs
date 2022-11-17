namespace Finaktiva.DDD_1.API.Commands
{
    public record CreatePersonCommand(Guid personId, string Name);
}
