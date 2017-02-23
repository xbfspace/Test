using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arch.Data.Test.OtherTest.MyRightManageDesign.Privilege;
using Arch.Data.Test.OtherTest.MyRightManageDesign.RightManagers.Model;

namespace Arch.Data.Test.OtherTest.MyRightManageDesign
{
    public class RightManager : IRightManger
    {
        #region grant
        public virtual bool GrantRightToRole(BusinessModuleInstance businessModule, Right right, Role role)
        {
            var sql = @"declare @rightAssignId int 
                        select @rightAssignId = id from right_assign where businessModuleInstance = {0} and right={1} and subject ={2} and subjectType={3})
                        if @rightAssignId is not null
                           begin 
                              update right_assign
                              set businessModuleInstance={0} , right={1}, subject={2} ,subjectType={3},grantType={4}
                           end
                        else
                           begin
                              insert into right_assign(businessModuleInstance,right,subject,subjectType,grantType)
                              values ({0},{1},{2},{3},{4})
                           end
                      
                        ";
            sql = string.Format(sql, businessModule.ID, right.ID, role.ID, GrantSubjectType.Role);
            Console.WriteLine(sql);
            return true;
        }


        public virtual bool GrantRightToRole(BusinessModuleInstance businessModule, Right right, User user)
        {
            var sql = @"declare @rightAssignId int 
                        select @rightAssignId = id from right_assign where businessModuleInstance = {0} and right={1} and subject ={2} and subjectType={3})
                        if @rightAssignId is not null
                           begin 
                              update right_assign
                              set businessModuleInstance={0} , right={1}, subject={2} ,subjectType={3},grantType={4}
                           end
                        else
                           begin
                              insert into right_assign(businessModuleInstance,right,subject,subjectType,grantType)
                              values ({0},{1},{2},{3},{4})
                           end
                      
                        ";
            sql = string.Format(sql, businessModule.ID, right.ID, user.ID, GrantSubjectType.User);
            Console.WriteLine(sql);
            return true;
        }
        #endregion


        #region query
        /// <summary>
        /// 查询业务模块向对象授予的所有权限
        /// </summary>
        /// <param name="subjectType"></param>
        /// <param name="subjectId"></param>
        /// <param name="grantType"></param>
        /// <returns></returns>
        public IEnumerable<Right> QueryRightByBusinessModule(int businessModuleInstanceId, GrantSubjectType subjectType, int subjectId, GrantType grantType)
        {
            var sql = string.Empty;
            sql = @"select b.*  from right_assign a,right b
                        where a.right = b.id 
                          and a.businessModuleInstance ={0} 
                          and grantType={1} 
                          and subject={2} 
                          and subjectType={3}";
            Console.WriteLine(string.Format(sql, businessModuleInstanceId, grantType, subjectId, subjectType));
            return null;
        }

        #endregion
    }
}
