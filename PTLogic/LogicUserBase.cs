using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTEntities;

namespace PTLogic
{
    public class LogicUserBase
    {
        /// <summary>
        /// 查询用户基础表里的列表信息（有关键词就查关键词条目）
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <returns></returns>
        public List<Users_Base> GetUserBaseList(string keyword)
        {
            //实例化数据库上下文类
            PetShopEntities pte = new PetShopEntities();
            //查询我们需要的数据
            var data = pte.Users_Base.ToList();
            //用户名模糊查询
            if (string.IsNullOrEmpty(keyword))
            {
                data = data.Where(p => p.UserName.Contains(keyword)).ToList(); // =>lambda表达式  该运算符读作"goes to"
            }

            return data;
        }

        /// <summary>
        /// 删除一条用户信息
        /// </summary>
        /// <param name="UID"></param>
        /// <returns></returns>
        public bool DelUserBase(int UID)
        {
            //实例化数据库上下文类
            PetShopEntities pte = new PetShopEntities();

            //先查询这个用户出来，再删除
            var data = pte.Users_Base.Find(UID);

            //如果有这个用户信息，则删除
            if (data != null)
            {
                //删除   
                pte.Users_Base.Remove(data);
                //保存操作
                pte.SaveChanges();

                return true;
            }


            return false;
        }

        /// <summary>
        /// 查询单个用户信息
        /// </summary>
        /// <returns></returns>
        public Users_Base GetSingleUserBase(int UID)
        {
            //实例化数据库上下文类
            PetShopEntities pte = new PetShopEntities();

            //先查询这个用户出来，再删除
            var data = pte.Users_Base.Find(UID);

            return data;

        }



        /// <summary>
        ///更新单个用户信息
        /// </summary>
        /// <returns></returns>
        public Users_Base UpdateUserBase(Users_Base userinfo)
        {
            //实例化数据库上下文类
            PetShopEntities pte = new PetShopEntities();

            //根据uid查询这条用户信息
            var data = pte.Users_Base.Where(p => p.UID == userinfo.UID).FirstOrDefault();

            //全部更新
            data.UserName = userinfo.UserName;
            data.Password = userinfo.Password;
            data.Phone = userinfo.Phone;
            //....

            //保存
            pte.SaveChanges();
            return data;
        }


        /// <summary>
        ///新增单个用户信息
        /// </summary>
        /// <returns></returns>
        public Users_Base CreateUserBase(Users_Base userinfo)
        {
            //实例化数据库上下文类
            PetShopEntities pte = new PetShopEntities();

            pte.Users_Base.Add(userinfo);
            //保存
            pte.SaveChanges();

            //返回这个用户对象
            return userinfo;
        }


    }
}
