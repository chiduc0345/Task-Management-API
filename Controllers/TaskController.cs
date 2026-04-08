using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskManager.DAO;
using TaskManager.Model;

namespace TaskManager.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TaskController:ControllerBase
    {
        taskDAO taskDao = new taskDAO();
        TaskIterm taskIterms = new TaskIterm();
        [Authorize]
        [HttpGet]
        public List<TaskIterm> GetAll ()
        {
            return taskDao.GetAll ();
           
        }
        [Authorize]
        [HttpPost]
        public IActionResult Insert([FromBody] TaskIterm taskIterms)
        {
            if (string.IsNullOrWhiteSpace(taskIterms.TenCongViec))
                return BadRequest("Ten không hợp lệ");
            if (string.IsNullOrWhiteSpace(taskIterms.LoaiCongViec))
                return BadRequest("Công việc không hợp lệ");
           
            if (taskIterms.HanChot == default)
                return BadRequest("Thời hạn không hợp lệ");
            taskDao.Insert(taskIterms);
            return Ok("Thêm thành công");
        }
        [Authorize]
        [HttpDelete]
        public IActionResult Delete(int macv)
        {
            if (macv <0)
                return BadRequest(400);

            if (taskDao.Delete(macv))
                return Ok("Xoa Thanh Cong");
            else return BadRequest(404);
        }
        [Authorize]
        [HttpPut]
        public IActionResult Update([FromBody]TaskIterm taskIterms)
        {
            if (string.IsNullOrEmpty(taskIterms.TenCongViec))
                return BadRequest("Ten Khong duoc de trong");
            if (string.IsNullOrEmpty(taskIterms.LoaiCongViec))
                return BadRequest("Loai cong viec khong duoc de trong");
           
            if (taskIterms.MaCV< 0)
                return BadRequest("Id khong Hop le");

            if (taskDao.Update(taskIterms))
                return Ok("Sua Thanh Cong");
            else return BadRequest("MaCV khong ton tai");
        }
        [Authorize]
        [HttpGet("search/{text}")]
        public List<TaskIterm> Search(string text)
        {
            return taskDao.Search(text);
        }
        [Authorize]
        [HttpGet("filter/{text}")]
        public List<TaskIterm> loc(string text)
        {
            if(string.IsNullOrWhiteSpace(text)||text=="Tất cả")
            {
                return taskDao.GetAll();
            }    
            else
                return taskDao.Loc(text);
          
        }
    }
}
