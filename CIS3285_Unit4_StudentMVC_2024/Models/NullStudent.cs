namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public class NullStudent : IStudentInterface
    {
        public int Id { get; set; } = -1;
        public string Name { get; set; } = "Null Student";
        public int Credits { get; set; } = -999;
    }
}
