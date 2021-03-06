using InfraStructure.DataBase;
using InfraStructure.Table;
using System.Collections.Generic;

namespace BlogSystem.Entity
{
    /// <summary>
    /// 专题
    /// </summary>
    public partial class Topic : OwnerTable
    {
        #region "model"

        /// <summary>
        /// 圈子名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 专题简介
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 包含关键字
        /// </summary>
        public string CustomTagList { get; set; }

        /// <summary>
        /// 是否允许投稿
        /// </summary>
        public bool IsPostable { get; set; }

        /// <summary>
        /// 是否需要审核
        /// </summary>
        public bool IsNeedApproval { get; set; }

        /// <summary>
        /// 标签表示文字
        /// </summary>
        public List<string> TagName { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "Topic";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "Topic";


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
        public static string MvcTitle = "专题";

        /// <summary>
        /// 按照序列号查找专题
        /// </summary>
        /// <param name="Sn"></param>
        /// <returns>专题</returns>
        public static Topic GetTopicBySn(string Sn)
        {
            return MongoDbRepository.GetRecBySN<Topic>(Sn);
        }

        /// <summary>
        /// 插入专题
        /// </summary>
        /// <param name="Newtopic"></param>
        /// <param name="OwnerId"></param>
        /// <returns>序列号</returns>
        public static string InsertTopic(Topic NewTopic, string OwnerId)
        {
            return OwnerTableOperator.InsertRec(NewTopic, OwnerId);
        }

        /// <summary>
        /// 删除专题
        /// </summary>
        /// <param name="DropTopic"></param>
        public static void DropTopic(Topic DropTopic)
        {
            MongoDbRepository.DeleteRec(DropTopic);
        }

        /// <summary>
        /// 修改专题
        /// </summary>
        /// <param name="OldTopic"></param>
        public static void UpdateTopic(Topic OldTopic)
        {
            MongoDbRepository.UpdateRec(OldTopic);
        }

        #endregion
    }
}
