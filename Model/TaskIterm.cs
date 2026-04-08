namespace TaskManager.Model
{
    public class TaskIterm
    {
        public string TenCongViec { get; set; } = "";
        public int MaCV { get; set; }

        public string LoaiCongViec { get; set; }

        public DateTime HanChot { get; set; }

        public bool TrangThai { get; set; } = false;
    }
}
