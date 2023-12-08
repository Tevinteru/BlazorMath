namespace BlazorMath.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string? Фамилия { get; set; }

        public string? Класс { get; set; }

        public DateTime? Время_начала { get; set; }

        public DateTime? Время_конца { get; set; }

        public int? Количество_прав_ответов { get; set; }

    }
}
