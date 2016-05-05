using System;
using System.Collections.Generic;
using System.Web.Mvc;
using InfraStructure.Helper;

namespace InfraStructure.Utility
{
    public class EnumExt
    {
        /// <summary>
        ///     ����ö�ٳ�Ա��ȡ�Զ�������EnumDisplayNameAttribute������DisplayName
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string GetEnumCustomDescription(object e)
        {
            //��ȡö�ٵ�Type���Ͷ���
            var t = e.GetType();
            //��ȡö�ٵ������ֶ�
            var ms = t.GetFields();
            //��������ö�ٵ������ֶ�
            foreach (var f in ms)
            {
                if (f.Name != e.ToString())
                {
                    continue;
                }
                //�ڶ�������true��ʾ����EnumDisplayNameAttribute�ļ̳���
                if (f.IsDefined(typeof (EnumDisplayNameAttribute), true))
                {
                    return
                        (f.GetCustomAttributes(typeof (EnumDisplayNameAttribute), true)[0] as EnumDisplayNameAttribute)
                            .DisplayName;
                }
            }
            //���û���ҵ��Զ������ԣ�ֱ�ӷ��������������
            return e.ToString();
        }

        /// <summary>
        ///     ����ö�٣���ö���Զ�������EnumDisplayNameAttribut��Display����ֵײ��SelectListItem��
        /// </summary>
        /// <param name="enumType">ö��</param>
        /// <returns></returns>
        public static List<SelectListItem> GetSelectList(Type enumType)
        {
            var selectList = new List<SelectListItem>();
            foreach (var e in Enum.GetValues(enumType))
            {
                selectList.Add(new SelectListItem {Text = GetEnumCustomDescription(e), Value = ((int) e).ToString()});
            }
            return selectList;
        }
    }
}