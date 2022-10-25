namespace Domain.DTOs;

public class SearchUserParameterDTO
{
    public string? UsernameContains { get; }

    public SearchUserParameterDTO(string? usernameContains)
    {
        this.UsernameContains = usernameContains;
    }
}