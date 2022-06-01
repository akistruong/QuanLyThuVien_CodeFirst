using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using QLTV2._0.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace QLTV2._0.Hubs
{
    public class CommentHub:Hub
    {
        readonly QuanLyThuVien30Context _context;
        public object NewtonSoft { get; private set; }

        public CommentHub(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
        public async Task SendReplyToGroup(string group, Replys body)
        {
            _context.Replys.Add(body);
            try
            {
                await _context.SaveChangesAsync();
                var reply = await _context.Replys.Include(x=>x.TaiKhoanNavigation).ThenInclude(x=>x.IdKhNavigation).FirstOrDefaultAsync(x=>x.IdReply==body.IdReply);
                var user = await _context.Taikhoans.FirstOrDefaultAsync(x => x.UserName == reply.UserName);
                var userInfo = await _context.KhachHangs.FirstOrDefaultAsync(x => x.IdKh == user.IdKh);
                await Clients.Group(group).SendAsync("ReceiveReply", reply, userInfo.TenKhachHang);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        public async Task SendMessageToGroup(string group,Comments body)
        {
            _context.Comments.Add(body);
            try
            {
                await _context.SaveChangesAsync();
                var comment = await   _context.Comments.FirstOrDefaultAsync(x => x.IdComment == body.IdComment);
                var user = await _context.Taikhoans.FirstOrDefaultAsync(x => x.UserName == comment.UserName);
                var userInfo = await _context.KhachHangs.FirstOrDefaultAsync(x => x.IdKh == user.IdKh);
                await Clients.Group(group).SendAsync("ReceiveMessage", comment, new
                {
                    Ten = userInfo.TenKhachHang,
                    Avt = user.avatar
                })  ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
        public async Task AddToGroup(string groupName)
        {
            var comments =  _context.Comments.Include(x => x.TaiKhoanNavigation).ToList();
            try
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, groupName.Trim());

                await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {groupName}.");
            }
            catch (Exception ex)
            {
                var er = ex.Message;
                Console.Write(ex.ToString());
            }
           
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }
    }
}
