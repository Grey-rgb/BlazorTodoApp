namespace Domain.DTOs;

public class TodoCreationDTO
{
    public int OwnerId { get; set; }
    public string Title { get; set; }

    public TodoCreationDTO(int ownerId, string Title)
    {
        this.OwnerId = ownerId;
        this.Title = Title; 
    }
}