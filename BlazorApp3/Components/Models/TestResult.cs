using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp3.Models
{
    public class TestResult
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("TestModel")]
        [Column("TestId")]
        public int TestId { get; set; }
        public TestModel? Test { get; set; }

        [ForeignKey("Student")]
        [Column("StudentId")]
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        [Column("Score")]
        public int Score { get; set; }
    }
}