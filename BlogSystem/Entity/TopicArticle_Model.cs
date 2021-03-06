using InfraStructure.DataBase;
using System;

namespace BlogSystem.Entity
{
    /// <summary>
    /// 专题文章
    /// </summary>
    public partial class TopicArticle : EntityBase
    {
        #region "model"

        /// <summary>
        /// 专题编号
        /// </summary>
        public string TopicID { get; set; }

        /// <summary>
        /// 文章统一编号
        /// </summary>
        public string ArticleID { get; set; }

        /// <summary>
        /// 发布状态
        /// </summary>
        public ApproveStatus PublishStatus { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "TopicArticle";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "TopicArticle";


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
        public static string MvcTitle = "专题文章";

        /// <summary>
        /// 按照序列号查找专题文章
        /// </summary>
        /// <param name="Sn"></param>
        /// <returns>专题文章</returns>
        public static TopicArticle GetTopicArticleBySn(string Sn)
        {
            return MongoDbRepository.GetRecBySN<TopicArticle>(Sn);
        }

        /// <summary>
        /// 插入专题文章
        /// </summary>
        /// <param name="Newtopicarticle"></param>
        /// <returns>序列号</returns>
        public static string InsertTopicArticle(TopicArticle NewTopicArticle)
        {
            return MongoDbRepository.InsertRec(NewTopicArticle);
        }

        /// <summary>
        /// 删除专题文章
        /// </summary>
        /// <param name="DropTopicArticle"></param>
        public static void DropTopicArticle(TopicArticle DropTopicArticle)
        {
            MongoDbRepository.DeleteRec(DropTopicArticle);
        }

        /// <summary>
        /// 修改专题文章
        /// </summary>
        /// <param name="OldTopicArticle"></param>
        public static void UpdateTopicArticle(TopicArticle OldTopicArticle)
        {
            MongoDbRepository.UpdateRec(OldTopicArticle);
        }
        #endregion
    }
}
