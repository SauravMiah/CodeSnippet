using InfraStructure.DataBase;
using System;

namespace BlogSystem.Entity
{
    /// <summary>
    /// 帐户信息
    /// </summary>
    public partial class GithubAccount : EntityBase
    {
        #region "model"

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 作者头像
        /// </summary>
        public string Avatar_url { get; set; }

        /// <summary>
        /// GitHub地址
        /// </summary>
        public string Html_url { get; set; }

        /// <summary>
        /// 最后登陆时间
        /// </summary>
        public DateTime LastAccess { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserInfoID { get; set; }

        /// <summary>
        /// 公司
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 博客
        /// </summary>
        public string Blog { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 粉丝人数
        /// </summary>
        public int Followers { get; set; }

        /// <summary>
        /// 关注人数
        /// </summary>
        public int Following { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        public override string GetCollectionName()
        {
            return "GithubAccount";
        }

        /// <summary>
        /// 数据集名称静态字段
        /// </summary>
        public static string CollectionName = "GithubAccount";


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
        public static string MvcTitle = "帐户信息";

        /// <summary>
        /// 按照序列号查找帐户信息
        /// </summary>
        /// <param name="Sn"></param>
        /// <returns>帐户信息</returns>
        public static GithubAccount GetGithubAccountBySn(string Sn)
        {
            return MongoDbRepository.GetRecBySN<GithubAccount>(Sn);
        }

        /// <summary>
        /// 插入帐户信息
        /// </summary>
        /// <param name="Newgithubaccount"></param>
        /// <returns>序列号</returns>
        public static string InsertGithubAccount(GithubAccount NewGithubAccount)
        {
            return MongoDbRepository.InsertRec(NewGithubAccount);
        }

        /// <summary>
        /// 删除帐户信息
        /// </summary>
        /// <param name="DropGithubAccount"></param>
        public static void DropGithubAccount(GithubAccount DropGithubAccount)
        {
            MongoDbRepository.DeleteRec(DropGithubAccount);
        }

        /// <summary>
        /// 修改帐户信息
        /// </summary>
        /// <param name="OldGithubAccount"></param>
        public static void UpdateGithubAccount(GithubAccount OldGithubAccount)
        {
            MongoDbRepository.UpdateRec(OldGithubAccount);
        }

        #endregion
    }
}
