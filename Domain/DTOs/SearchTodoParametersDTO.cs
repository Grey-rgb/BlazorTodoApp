namespace Domain.DTOs;

public class SearchTodoParametersDTO
{
    public string? Username { get; }
    public int? UserID { get; }
    public bool? CompletedStatus { get; }
    public string? TitleContains { get; }

    public SearchTodoParametersDTO(string? username, int? userId, bool? completedStatus, string? titleContains)
    {
        this.Username = username;
        this.UserID = userId;
        this.CompletedStatus = completedStatus;
        this.TitleContains = titleContains;
    }
}