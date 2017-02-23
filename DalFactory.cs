using Arch.Data.Test.Dao;
using Arch.Data.Test.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test
{
    /// <summary>
    /// DALFactory
    /// </summary>
	public partial class DALFactory
    {
        private static readonly IPersonGenDao personGenDao = new PersonGenDao();


        /// <summary>
        /// Property PersonGenDao
        /// </summary>
        public static IPersonGenDao PersonGenDao
        {
            get
            {
                return personGenDao;
            }
        }

    }
}
