using InfraStructure.DataBase;
using System;

namespace BlogSystem.TagSystem
{
    /// <summary>
    /// 官方标签
    /// </summary>
    public partial class Tag : EntityBase
    {
        #region "model"

        /// <summary>
        /// 标签表示文字
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// 分组
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// 区分大小写
        /// </summary>
        public bool IsCaseSensitive { get; set; }

        /// <summary>
        /// 是否只是包含即可
        /// </summary>
        public bool IsOnlyContain { get; set; }

        /// <summary>
        /// 基础词
        /// </summary>
        public string BaseTagName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "Tag";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "Tag";


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
        public static string MvcTitle = "官方标签";

        /// <summary>
        /// 按照序列号查找官方标签
        /// </summary>
        /// <param name="Sn"></param>
        /// <returns>官方标签</returns>
        public static Tag GetTagBySn(string Sn)
        {
            return MongoDbRepository.GetRecBySN<Tag>(Sn);
        }

        /// <summary>
        /// 插入官方标签
        /// </summary>
        /// <param name="Newtag"></param>
        /// <returns>序列号</returns>
        public static string InsertTag(Tag NewTag)
        {
            return MongoDbRepository.InsertRec(NewTag);
        }

        /// <summary>
        /// 删除官方标签
        /// </summary>
        /// <param name="DropTag"></param>
        public static void DropTag(Tag DropTag)
        {
            MongoDbRepository.DeleteRec(DropTag);
        }

        /// <summary>
        /// 修改官方标签
        /// </summary>
        /// <param name="OldTag"></param>
        public static void UpdateTag(Tag OldTag)
        {
            MongoDbRepository.UpdateRec(OldTag);
        }

        #endregion
    }
}
