using BlogSystem.BussinessLogic;
using BlogSystem.Entity;
using InfraStructure.DataBase;
using MongoDB.Bson;
using System.Collections.Generic;

namespace BlogSystem.DisplayEntity
{
    /// <summary>
    /// 文章表示综合体
    /// </summary>
    public partial class ArticleBody : CacheEntityBase
    {
        #region "model"

        /// <summary>
        /// 作者信息
        /// </summary>
        public UserInfo AuthorInfo { get; set; }

        /// <summary>
        /// 关注数
        /// </summary>
        public int FocusCnt { get; set; }

        /// <summary>
        /// 粉丝数
        /// </summary>
        public int FollowCnt { get; set; }

        /// <summary>
        /// 整体被收藏数
        /// </summary>
        public int AuthorStockCnt { get; set; }

        /// <summary>
        /// 文章信息
        /// </summary>
        public Article ArticleInfo { get; set; }

        /// <summary>
        /// 文集名称
        /// </summary>
        public string CollectionTitle { get; set; }

        /// <summary>
        /// 阅读数
        /// </summary>
        public int ReadCnt { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        public int CommentCnt { get; set; }

        /// <summary>
        /// 评论人数
        /// </summary>
        public int CommentAccountCnt { get; set; }

        /// <summary>
        /// 收藏数
        /// </summary>
        public int StockCnt { get; set; }

        /// <summary>
        /// 收藏者
        /// </summary>
        public List<UserInfo> StockAccountList { get; set; }

        /// <summary>
        /// 同文集中前一篇文章
        /// </summary>
        public Article PreviousArticleInCollection { get; set; }

        /// <summary>
        /// 同文集中后一篇文章
        /// </summary>
        public Article NextArticleInCollection { get; set; }

        /// <summary>
        /// 文章评分
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// 统计信息
        /// </summary>
        public AnlyzeResult MarkDownAnlyze { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "ArticleBody";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "ArticleBody";


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
        public static string MvcTitle = "文章表示综合体";

        /// <summary>
        /// 插入文章表示综合体
        /// </summary>
        /// <param name="NewArticleBody">文章表示综合体</param>
        public static ObjectId InsertArticleBody(ArticleBody NewArticleBody)
        {
            return MongoDbRepository.InsertCacheRec(NewArticleBody);
        }

        #endregion
    }
}
