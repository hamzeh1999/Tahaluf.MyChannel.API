using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.MyChannel.core.common;
using Tahaluf.MyChannel.core.data;
using Tahaluf.MyChannel.Core.DTO;
using Tahaluf.MyChannel.Core.Repository;

namespace Tahaluf.MyChannel.Infra.Repository
{
    public class ChannelRepository : IChannelRepository
    {
        private readonly IDBContext DBContext;
        public ChannelRepository(IDBContext _DBContext)
        {
            DBContext = _DBContext;
        }
        public bool CreateChannel(Channel channel)
        {
            var p = new DynamicParameters();
            p.Add("@Channelname_A", channel.ChannelId, dbType: DbType.String);
            p.Add("@pCategorydescription", channel., dbType: DbType.String);
            p.Add("@userID_A", channel.UserId, dbType: DbType.String);
            p.Add("@Channeldate_A", channel.ChannelDate, dbType: DbType.DateTime);
            // dbContext.Connection.Query<ClassName>("PackageName.ProcedureName" ,[parameter] ,CommandType: CommandType.StoredProcedure);
            var result = DBContext.Connection.Query<Category_>("CATEGORY_PACKAGE.CREATECATEGORY", p, commandType: CommandType.StoredProcedure); // p is the dynamic parameter
            return true;
        }

        public bool DeleteChannel(int channelId)
        {
            var p = new DynamicParameters();
            p.Add("@pCategoryId", channelId, dbType: DbType.Int32);
            var result = DBContext.Connection.Query<Channel>("CATEGORY_PACKAGE.DELETECATEGORY", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Channel> GetAllChannels()
        {
            // dbContext.Connection.Query<ClassName>("PackageName.ProcedureName" ,[parameter] ,CommandType: CommandType.StoredProcedure);
            //بستدعي البكج يلي بالداتابيز ك ليست
            IEnumerable<Channel> result = DBContext.Connection.Query<Channel>("CATEGORY_PACKAGE.GETALLCATEGORY", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<ChannelSearchingDTO> SearchingChannel(ChannelSearchingCallDTO channel)
        {
            var p = new DynamicParameters();
            p.Add("@Book_Name", channel.pchannelName, dbType: DbType.String);
            p.Add("@date_from ", channel.pdate_from, dbType: DbType.DateTime);
            p.Add("@date_to ", channel.pdate_to, dbType: DbType.DateTime);
            p.Add("@Course_Name ", channel.pcategoryName, dbType: DbType.String);
            IEnumerable<ChannelSearchingDTO> result = DBContext.Connection.Query<ChannelSearchingDTO>("SearchingBook", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateChannel(Channel channel)
        {
            var p = new DynamicParameters();
            p.Add("@pCategoryId", channel.ChannelId, dbType: DbType.Int32);
            p.Add("@pCategoryName", channel.ChannelName, dbType: DbType.String);
            p.Add("@pCategorydescription", channel.ChannelDate, dbType: DbType.DateTime);
            p.Add("@pCategoryimage", channel.ChannelDescription, dbType: DbType.String);
            // dbContext.Connection.Query<ClassName>("PackageName.ProcedureName" ,[parameter] ,CommandType: CommandType.StoredProcedure);
            var result = DBContext.Connection.Query<Channel>("CATEGORY_PACKAGE.UPDATECATEGORY", p, commandType: CommandType.StoredProcedure); // p is the dynamic parameter
            return true;
        }

        public List<Channel> videoscounter(int channelId)

        {
            var p = new DynamicParameters();
            p.Add("@Course_Name ", channelId, dbType: DbType.Int32);
            IEnumerable<Channel> result = DBContext.Connection.Query<Channel>("Channel_Package.videoscounter", p,commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
