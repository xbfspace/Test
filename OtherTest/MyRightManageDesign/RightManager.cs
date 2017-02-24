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


        public virtual bool GrantRightToUser(BusinessModuleInstance businessModule, Right right, User user)
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

        public virtual bool GrantRightsToUser(BusinessModuleInstance businessModule, IEnumerable<Right> rights, User user) {
            foreach (var right in rights) {
                GrantRightToUser(businessModule, right, user);
            }
            return true;
        }
        #endregion


        #region query
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
        public RightResult QueryRightResult(int businessModuleId, int rightId, GrantSubjectType subjectType, int subjectId) {
            var sql = string.Empty;
            sql = @"select b.*,a.grantType from right_assign a 
                     where a.businessModuleInstance={0}
                       and a.right={1}
                       and a.subjectType={2}
                       and a.subjectId={3}
                       and a.right=b.id";
            return null;
        }
        public RightResult QueryMergedRightResult(int businessModuleId, int rightId, int userId) {
            var sql = string.Empty;
            sql = @"select b.*,a.grantType from right_assign a 
                     where a.businessModuleInstance={0}
                       and a.right={1}
                       and a.right=b.id";
            //todo :如果b.priority=0，且结果集中存在grantType=0的数据
            //从结果过滤出所有的subjectType 和 subject,查询用户所属的角色、组织等进行比较
            return null;
        }
        #endregion
    }
}
