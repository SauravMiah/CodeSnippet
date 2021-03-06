using BlogSystem.Entity;
using InfraStructure.DataBase;

namespace BlogSystem.DisplayEntity
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public partial class UserItemBody : CacheEntityBase
    {
        #region "model"

        /// <summary>
        /// 文章数
        /// </summary>
        public int ArticleCnt { get; set; }

        /// <summary>
        /// 关注数
        /// </summary>
        public int FocusCnt { get; set; }

        /// <summary>
        /// 被关注数
        /// </summary>
        public int FollwersCnt { get; set; }

        /// <summary>
        /// 被收藏数
        /// </summary>
        public int StockCnt { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        public UserInfo UserInfo { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "UserItemBody";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "UserItemBody";


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
        /// <param name="NewUserItemBody">用户信息</param>
        public static void InsertUserItemBody(UserItemBody NewUserItemBody)
        {
            MongoDbRepository.InsertCacheRec(NewUserItemBody);
        }

        #endregion
    }
}
