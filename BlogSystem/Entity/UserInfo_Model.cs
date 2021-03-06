using InfraStructure.DataBase;
using System.Collections.Generic;

namespace BlogSystem.Entity
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public partial class UserInfo : EntityBase
    {
        #region "model"

        /// <summary>
        /// 专题编号列表
        /// </summary>
        public List<string> TopicList { get; set; }

        /// <summary>
        /// 关注标签列表
        /// </summary>
        public List<string> TagList { get; set; }

        /// <summary>
        /// 注册方式下的帐户编号
        /// </summary>
        public string RegisterAccountID { get; set; }

        /// <summary>
        /// 注册方式
        /// </summary>
        public string RegisterMethod { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        public UserType Privilege { get; set; }

        /// <summary>
        /// 表示名称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 作者头像
        /// </summary>
        public string Avatar_url { get; set; }

        /// <summary>
        /// 订阅难易度
        /// </summary>
        public List<ArticleLevel> Level { get; set; }

        /// <summary>
        /// 订阅分类
        /// </summary>
        public List<string> Catalog { get; set; }

        /// <summary>
        /// 订阅标签
        /// </summary>
        public string ContainTag { get; set; }

        /// <summary>
        /// 过滤标签
        /// </summary>
        public string AntiTag { get; set; }

        /// <summary>
        /// 支付宝二维码
        /// </summary>
        public string AlipayImageURL { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "UserInfo";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "UserInfo";


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
        /// 按照序列号查找用户信息
        /// </summary>
        /// <param name="Sn"></param>
        /// <returns>用户信息</returns>
        public static UserInfo GetUserInfoBySn(string Sn)
        {
            return MongoDbRepository.GetRecBySN<UserInfo>(Sn);
        }

        /// <summary>
        /// 插入用户信息
        /// </summary>
        /// <param name="Newuserinfo"></param>
        /// <returns>序列号</returns>
        public static string InsertUserInfo(UserInfo NewUserInfo)
        {
            return MongoDbRepository.InsertRec(NewUserInfo);
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="DropUserInfo"></param>
        public static void DropUserInfo(UserInfo DropUserInfo)
        {
            MongoDbRepository.DeleteRec(DropUserInfo);
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="OldUserInfo"></param>
        public static void UpdateUserInfo(UserInfo OldUserInfo)
        {
            MongoDbRepository.UpdateRec(OldUserInfo);
        }

        #endregion
    }
}
