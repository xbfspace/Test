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
        public virtual bool GrantRightToRole(Right right, Role role,GrantType grantType)
        {
            var sql = @"declare @rightAssignId int 
                        select @rightAssignId = id from right_assign where businessModule = {0} and right={1} and subject ={2} and subjectType={3})
                        if @rightAssignId is not null
                           begin 
                              update right_assign
                              set businessModule={0} , right={1}, subject={2} ,subjectType={3},grantType={4}
                           end
                        else
                           begin
                              insert into right_assign(businessModuleId,right,subject,subjectType,grantType)
                              values ({0},{1},{2},{3},{4})
                           end
                      
                        ";
            sql = string.Format(sql, right.BusinessModule.Code, right.Code, role.ID, GrantSubjectType.Role);
            Console.WriteLine(sql);
            return true;
        }


        public virtual bool GrantRightToUser(Right right, User user)
        {
            var sql = @"declare @rightAssignId int 
                        select @rightAssignId = id from right_assign where businessModule = {0} and right={1} and subject ={2} and subjectType={3})
                        if @rightAssignId is not null
                           begin 
                              update right_assign
                              set businessModule={0} , right={1}, subject={2} ,subjectType={3},grantType={4}
                           end
                        else
                           begin
                              insert into right_assign(businessModule,right,subject,subjectType,grantType)
                              values ({0},{1},{2},{3},{4})
                           end
                      
                        ";
            sql = string.Format(sql, right.BusinessModule.ID, right.Code, user.ID, GrantSubjectType.User);
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
        public IEnumerable<Right> QueryRightByBusinessModule(int businessModuleId, GrantSubjectType subjectType, int subjectId, GrantType grantType) {

        }

        #endregion
    }
}
