
public class Comments
{
    public int Id { get; set; }
    public string CommentText { get; set; }
    public int SkillId { get; set; }


// create a method that generates a comment for a given skill
public string GenerateComment(int skillId)
{
    // In a real application, you would likely retrieve the skill information from a database
    // For this example, we will just return a simple comment based on the skillId
    return $"This is a comment for skill with ID: {skillId}";
}
}
