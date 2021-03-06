using InfraStructure.DataBase;
using System;

namespace BlogSystem.BussinessLogic
{
    /// <summary>
    /// 配置
    /// </summary>
    public partial class SiteConfig : EntityBase
    {
        #region "model"

        /// <summary>
        /// 置顶文章编号
        /// </summary>
        public string TopArticleID { get; set; }
        /// <summary>
        /// 目录项目
        /// </summary>
        public string[] CatalogItem { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "SiteConfig";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "SiteConfig";


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
        public static string MvcTitle = "配置";

        /// <summary>
        /// 按照序列号查找配置
        /// </summary>
        /// <param name="Sn"></param>
        /// <returns>配置</returns>
        public static SiteConfig GetSiteConfigBySn(string Sn)
        {
            return MongoDbRepository.GetRecBySN<SiteConfig>(Sn);
        }

        /// <summary>
        /// 插入配置
        /// </summary>
        /// <param name="Newsiteconfig"></param>
        /// <returns>序列号</returns>
        public static string InsertSiteConfig(SiteConfig NewSiteConfig)
        {
            return MongoDbRepository.InsertRec(NewSiteConfig);
        }

        /// <summary>
        /// 删除配置
        /// </summary>
        /// <param name="DropSiteConfig"></param>
        public static void DropSiteConfig(SiteConfig DropSiteConfig)
        {
            MongoDbRepository.DeleteRec(DropSiteConfig);
        }

        /// <summary>
        /// 修改配置
        /// </summary>
        /// <param name="OldSiteConfig"></param>
        public static void UpdateSiteConfig(SiteConfig OldSiteConfig)
        {
            MongoDbRepository.UpdateRec(OldSiteConfig);
        }

        #endregion
    }
}
