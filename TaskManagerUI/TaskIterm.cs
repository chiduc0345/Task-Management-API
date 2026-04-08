using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerUI
{
    public class TaskIterm
    {
        public int MaCV {  get; set; }
        public string TenCongViec { get; set; }  
        public string LoaiCongViec { get; set; } 
        public DateTime HanChot { get; set; } = DateTime.Now;
        public bool TrangThai {  get; set; }= false;
    }
}
