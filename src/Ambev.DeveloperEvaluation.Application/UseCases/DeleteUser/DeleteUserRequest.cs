namespace Ambev.DeveloperEvaluation.Application.UseCases.DeleteUser;

/// <summary>
/// Request model for deleting a user
/// </summary>
public class DeleteUserRequest
{
    /// <summary>
    /// The unique identifier of the user to delete
    /// </summary>
    public Guid Id { get; set; }
}
