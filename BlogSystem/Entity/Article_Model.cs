using InfraStructure.DataBase;
using InfraStructure.Table;
using System;
using System.Collections.Generic;

namespace BlogSystem.Entity
{
    /// <summary>
    /// 文章
    /// </summary>
    public partial class Article : OwnerTable
    {
        #region "model"

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        public string CustomTagList { get; set; }

        /// <summary>
        /// 标签表示文字
        /// </summary>
        public List<string> TagName { get; set; }

        /// <summary>
        /// 标题配图
        /// </summary>
        public string ImageURL { get; set; }

        /// <summary>
        /// MarkDown文档编号
        /// </summary>
        public string MDDocumentID { get; set; }

        /// <summary>
        /// 是否私有
        /// </summary>
        public bool IsPrivate { get; set; }

        /// <summary>
        /// 是否原创
        /// </summary>
        public bool IsOriginal { get; set; }

        /// <summary>
        /// 是否申请发布到首页
        /// </summary>
        public bool IsFirstPage { get; set; }

        /// <summary>
        /// 发布状态
        /// </summary>
        public ApproveStatus PublishStatus { get; set; }

        /// <summary>
        /// 审核留言
        /// </summary>
        public string FirstPageMessage { get; set; }

        /// <summary>
        /// 所属文集编号
        /// </summary>
        public string CollectionID { get; set; }

        /// <summary>
        /// 首页审核申请时间
        /// </summary>
        public DateTime PublishDateTime { get; set; }

        /// <summary>
        /// 首页审核确认时间
        /// </summary>
        public DateTime ConfirmDateTime { get; set; }

        /// <summary>
        /// 推广文字
        /// </summary>
        public string AdvText { get; set; }

        /// <summary>
        /// 推广链接
        /// </summary>
        public string AdvLink { get; set; }

        /// <summary>
        /// 推广图片
        /// </summary>
        public string AdvImageUrl { get; set; }

        /// <summary>
        /// 关闭评论
        /// </summary>
        public bool IsCloseComment { get; set; }

        /// <summary>
        /// 难易度
        /// </summary>
        public ArticleLevel Level { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// 是否允许被收录
        /// </summary>
        public bool IsTopicable { get; set; }

        /// <summary>
        /// 是否需要被收录审核
        /// </summary>
        public bool IsNeedTopicApproval { get; set; }

        /// <summary>
        /// 加入自己的专题
        /// </summary>
        public bool IsPutToMyTopic { get; set; }

        /// <summary>
        /// 启用支付功能
        /// </summary>
        public bool IsEnableAliPay { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "Article";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "Article";


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
        public static string MvcTitle = "文章";

        /// <summary>
        /// 按照序列号查找文章
        /// </summary>
        /// <param name="Sn"></param>
        /// <returns>文章</returns>
        public static Article GetArticleBySn(string Sn)
        {
            return MongoDbRepository.GetRecBySN<Article>(Sn);
        }

        /// <summary>
        /// 插入文章
        /// </summary>
        /// <param name="Newarticle"></param>
        /// <param name="OwnerId"></param>
        /// <returns>序列号</returns>
        public static string InsertArticle(Article NewArticle, string OwnerId)
        {
            return OwnerTableOperator.InsertRec(NewArticle, OwnerId);
        }

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="DropArticle"></param>
        public static void DropArticle(Article DropArticle)
        {
            MongoDbRepository.DeleteRec(DropArticle);
        }

        /// <summary>
        /// 修改文章
        /// </summary>
        /// <param name="OldArticle"></param>
        public static void UpdateArticle(Article OldArticle)
        {
            MongoDbRepository.UpdateRec(OldArticle);
        }

        #endregion
    }
}
