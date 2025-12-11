namespace Luisma4
{
    public record class DarioServiceResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool Married { get; set; }
        public string Hobbies { get; set; }
    }
}