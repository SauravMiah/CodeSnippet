using InfraStructure.DataBase;
using InfraStructure.Table;

namespace BlogSystem.Entity
{
    /// <summary>
    /// 用户动作
    /// </summary>
    public partial class Stock : OwnerTable
    {
        #region "model"

        /// <summary>
        /// 文章全局编号
        /// </summary>
        public string ArticleID { get; set; }

        /// <summary>
        /// 作者编号
        /// </summary>
        public string AuthorID { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "Stock";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "Stock";


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
        public static string MvcTitle = "用户动作";

        /// <summary>
        /// 按照序列号查找用户动作
        /// </summary>
        /// <param name="Sn"></param>
        /// <returns>用户动作</returns>
        public static Stock GetStockBySn(string Sn)
        {
            return MongoDbRepository.GetRecBySN<Stock>(Sn);
        }

        /// <summary>
        /// 插入用户动作
        /// </summary>
        /// <param name="Newstock"></param>
        /// <param name="OwnerId"></param>
        /// <returns>序列号</returns>
        public static string InsertStock(Stock NewStock, string OwnerId)
        {
            return OwnerTableOperator.InsertRec(NewStock, OwnerId);
        }

        /// <summary>
        /// 删除用户动作
        /// </summary>
        /// <param name="DropStock"></param>
        public static void DropStock(Stock DropStock)
        {
            MongoDbRepository.DeleteRec(DropStock);
        }

        /// <summary>
        /// 修改用户动作
        /// </summary>
        /// <param name="OldStock"></param>
        public static void UpdateStock(Stock OldStock)
        {
            MongoDbRepository.UpdateRec(OldStock);
        }

        #endregion
    }
}
