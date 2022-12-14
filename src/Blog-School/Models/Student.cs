namespace Blog.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? Username { get; set; }
        public string? Modulo { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public ICollection<Post>? Posts { get; }
    }
}