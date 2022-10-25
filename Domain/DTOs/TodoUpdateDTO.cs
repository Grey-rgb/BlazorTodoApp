public class TodoUpdateDTO
{
    public int ID { get; }
    public int? OwnerID { get; set; }
    public string? Title { get; set; }
    public bool? IsCompleted { get; set; }

    public TodoUpdateDTO(int id)
    {
        this.ID = id;
    }
}