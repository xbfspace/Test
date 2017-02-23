using Arch.Data.Test.Entity;
using Arch.Data.Test.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.Dao
{
    /// <summary>
    ///
    /// </summary>
    public partial class PersonGenDao : IPersonGenDao
    {
        readonly BaseDao baseDao = BaseDaoFactory.CreateBaseDao("DalTestLogic");

        //特别注意，如果是可空类型，建议以如下方式使用：
        // var data = reader["field"];
        // entity.stringData = data == null ? data : data.ToString();
        //如需要手工映射，请反注释如下代码，并注意转换类型
        /*
        /// <summary>
        /// 手工映射，建议使用1.2.0.5版本以上的VisitDataReader
        /// </summary>
        /// <returns>结果</returns>
        public PersonGen OrmByHand(string sql)
        {
            try
            {
                return baseDao.VisitDataReader<PersonGen>(sql, (reader) =>
                {
                    PersonGen entity = new PersonGen();
					if(reader.Read())
					{
                        entity.CityId = reader["CityId"];
                        entity.ContryId = reader["ContryId"];
                        entity.ID = reader["ID"];
                        entity.Remark = reader["Remark"];
                    }
                    return entity;
                });

                //PersonGen entity = new PersonGen();
                //using(var reader = baseDao.SelectDataReader(sql))
                //{
					//if(reader.Read())
					//{
                        //entity.CityId = reader["CityId"];
                        //entity.ContryId = reader["ContryId"];
                        //entity.ID = reader["ID"];
                        //entity.Remark = reader["Remark"];
	                //}
                //}
                //return entity;
            }
            catch (Exception ex)
            {
                throw new DalException("调用PersonGenDao时，访问OrmByHand时出错", ex);
            }
        }
        */
        /// <summary>
        /// 修改PersonGen
        /// </summary>
        /// <param name="personGen">PersonGen实体对象</param>
        /// <returns>状态代码</returns>
        public int UpdatePersonGen(PersonGen personGen)
        {
            try
            {
                Object result = baseDao.Update<PersonGen>(personGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("调用PersonGen时，访问Update时出错", ex);
            }
        }
        /// <summary>
        /// 删除PersonGen
        /// </summary>
        /// <param name="personGen">PersonGen实体对象</param>
        /// <returns>状态代码</returns>
        public int DeletePersonGen(PersonGen personGen)
        {
            try
            {
                Object result = baseDao.Delete<PersonGen>(personGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("调用PersonGen时，访问Delete时出错", ex);
            }
        }
        /// <summary>
        /// 根据主键获取PersonGen信息
        /// </summary>
        /// <param name="iD"></param>
        /// <returns>PersonGen信息</returns>
        public PersonGen FindByPk(long iD)
        {
            try
            {
                return baseDao.GetByKey<PersonGen>(iD);
            }
            catch (Exception ex)
            {
                throw new DalException("调用PersonGenDao时，访问FindByPk时出错", ex);
            }
        }
        /// <summary>
        /// 获取所有PersonGen信息
        /// </summary>
        /// <returns>PersonGen列表</returns>
        public IList<PersonGen> GetAll()
        {
            try
            {
                return baseDao.GetAll<PersonGen>();
            }
            catch (Exception ex)
            {
                throw new DalException("调用PersonGenDao时，访问GetAll时出错", ex);
            }
        }
        /// <summary>
        /// 取得总记录数
        /// </summary>
        /// <returns>记录数</returns>
        public long Count()
        {
            try
            {
                String sql = "SELECT count(1) from Person  with (nolock)  ";
                object obj = baseDao.ExecScalar(sql);
                long ret = Convert.ToInt64(obj);
                return ret;
            }
            catch (Exception ex)
            {
                throw new DalException("调用PersonGenDao时，访问Count时出错", ex);
            }
        }
        /// <summary>
        ///  检索PersonGen，带翻页
        /// </summary>
        /// <param name="obj">PersonGen实体对象检索条件</param>
        /// <param name="pagesize">每页记录数</param>
        /// <param name="pageNo">页码</param>
        /// <returns>检索结果</returns>
        public IList<PersonGen> GetListByPage(PersonGen obj, int pagesize, int pageNo)
        {
            try
            {
                StringBuilder sbSql = new StringBuilder(200);

                sbSql.Append(@"select CityId, ContryId, ID, Remark from Person (nolock) ");
                sbSql.Append(" order by ID desc ");
                sbSql.Append(string.Format("OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", (pageNo - 1) * pagesize, pagesize));
                IList<PersonGen> list = baseDao.SelectList<PersonGen>(sbSql.ToString());
                return list;
            }
            catch (Exception ex)
            {
                throw new DalException("调用PersonGenDao时，访问GetListByPage时出错", ex);
            }
        }

        /// <summary>
        ///  批量插入PersonGen
        /// </summary>
        /// <param name="personGen">PersonGen实体对象列表</param>
        /// <returns>状态代码</returns>
        public bool BulkInsertPersonGen(IList<PersonGen> personGenList)
        {
            try
            {
                return baseDao.BulkInsert<PersonGen>(personGenList);
            }
            catch (Exception ex)
            {
                throw new DalException("调用PersonGenDao时，访问BulkInsert时出错", ex);
            }
        }

        public int InsertPersonGen(PersonGen personGen)
        {
            try
            {

                //return (int)baseDao.Insert<PersonGen>(personGen);
                baseDao.Insert<PersonGen>(personGen);
                return 1;
            }
            catch (Exception ex){
                throw new DalException("dao出错");
            }
        }
    }
}
