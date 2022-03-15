using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.MyChannel.core.data;
using Tahaluf.MyChannel.Core.DTO;
using Tahaluf.MyChannel.Core.Repository;

namespace Tahaluf.MyChannel.Infra.Repository
{
    public class CommentRepository : ICommentRepository
    {
        public bool CREATECOMMENT(Comment_ comment)
        {
            throw new NotImplementedException();
        }

        public bool DELETECOMMENT(int commentId)
        {
            throw new NotImplementedException();
        }

        public List<Comment_> GETALLCOMMENT()
        {
            throw new NotImplementedException();
        }

        public List<UserCommentDTO> GETCOMMENTSONVEDIO(int videoId)
        {
            throw new NotImplementedException();
        }

        public bool UPDATECOMMENT(Comment_ comment)
        {
            throw new NotImplementedException();
        }
    }
}
