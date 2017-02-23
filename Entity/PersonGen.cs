using Arch.Data.Orm;
using System;
using System.Data;

namespace Arch.Data.Test.Entity
{

    /// <summary>
    /// Person
    /// </summary>
    [Serializable]
    [Table(Name = "Person_{0}")]
    public partial class PersonGen
    {
        /// <summary>
        /// </summary>
        [Column(Name = "CityId", ColumnType = DbType.Int32)]
        public int? CityId { get; set; }
        /// <summary>
        /// </summary>
        [Column(Name = "ContryId", ColumnType = DbType.Int32)]
        public int? ContryId { get; set; }
        /// <summary>
        /// </summary>
        [Column(Name = "ID", ColumnType = DbType.Int64), ID, PK]
        public long ID { get; set; }
        /// <summary>
        /// </summary>
        [Column(Name = "Remark", ColumnType = DbType.String, Length = 50)]
        public string Remark { get; set; }
    }
}
