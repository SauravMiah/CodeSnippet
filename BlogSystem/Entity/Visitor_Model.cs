using InfraStructure.DataBase;
using System.Collections.Generic;

namespace BlogSystem.Entity
{
    /// <summary>
    /// 访客
    /// </summary>
    public partial class Visitor : CacheEntityBase
    {
        #region "model"

        /// <summary>
        /// 文章全局编号
        /// </summary>
        public string ArticleID { get; set; }

        /// <summary>
        /// UserHostAddress
        /// </summary>
        public string UserHostAddress { get; set; }

        /// <summary>
        /// UserLanguages
        /// </summary>
        public List<string> UserLanguages { get; set; }

        /// <summary>
        /// UserAgent
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// UserHostName
        /// </summary>
        public string UserHostName { get; set; }

        /// <summary>
        /// UserInfoId
        /// </summary>
        public string UserInfoId { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "Visitor";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "Visitor";


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
        public static string MvcTitle = "访客";

        /// <summary>
        /// 插入访客
        /// </summary>
        /// <param name="NewVisitor">访客</param>
        public static void InsertVisitor(Visitor NewVisitor)
        {
            MongoDbRepository.InsertCacheRec(NewVisitor);
        }

        #endregion
    }
}