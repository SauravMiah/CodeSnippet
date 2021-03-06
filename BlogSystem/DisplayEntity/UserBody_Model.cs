using InfraStructure.DataBase;
using System.Collections.Generic;
using BlogSystem.Entity;

namespace BlogSystem.DisplayEntity
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public partial class UserBody : CacheEntityBase
    {
        #region "model"

        /// <summary>
        /// UserInfoSN
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// GitHub信息
        /// </summary>
        public GithubAccount GitInfo { get; set; }

        /// <summary>
        /// QQ信息
        /// </summary>
        public QQAccount QQInfo { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        public UserInfo UserInfo { get; set; }

        /// <summary>
        /// 关注的人
        /// </summary>
        public List<UserInfo> FocusList { get; set; }

        /// <summary>
        /// 被谁关注
        /// </summary>
        public List<UserInfo> FollowList { get; set; }

        /// <summary>
        /// 收藏的文章
        /// </summary>
        public List<ArticleItemBody> StockList { get; set; }

        /// <summary>
        /// 作者文章
        /// </summary>
        public List<ArticleItemBody> ArticleList { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "UserBody";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "UserBody";


        /// <summary>
        /// 数据主键前缀
        /// </summary>
        public override string GetPrefix()
        {
            return string.Empty;
        }

        /// <summary>
        /// 数据主键前缀静态字段
        /// </summary>
        public static string Prefix = string.Empty;

        /// <summary>
        /// Mvc画面的标题
        /// </summary>
        public static string MvcTitle = "用户信息";

        /// <summary>
        /// 插入用户信息
        /// </summary>
        /// <param name="NewUserBody">用户信息</param>
        public static void InsertUserBody(UserBody NewUserBody)
        {
            MongoDbRepository.InsertCacheRec(NewUserBody);
        }

        #endregion
    }
}
