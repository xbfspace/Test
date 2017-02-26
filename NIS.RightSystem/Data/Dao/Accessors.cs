using NIS.RightSystem.Data.Dao.AccessorImplement;
using NIS.RightSystem.Data.Dao.AccessorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIS.RightSystem.Data.Dao
{
    public class Accessors
    {
        private static IRightAccessor _right;
        public IRightAccessor Right {
            get {
                if (_right==null) {
                    _right = new RightAccessor();
                }
                return _right;
            }
        }


        private static IBusinessInstanceAccessor _businessInstance;
        public IBusinessInstanceAccessor BusinessInstance {
            get {
                if (_businessInstance==null) {
                    _businessInstance = new BusinessInstanceAccessor();
                }
                return _businessInstance;
            }
        }

        private static IBusinessTemplateAccessor _businessTemplate;
        public IBusinessTemplateAccessor BusinessTemplate
        {
            get
            {
                if (_businessTemplate == null)
                {
                    _businessTemplate = new BusinessTemplateAccessor();
                }
                return _businessTemplate;
            }
        }

        private static IRightAssignAccessor _rightAssign;
        public IRightAssignAccessor RightAssign
        {
            get
            {
                if (_rightAssign == null)
                {
                    _rightAssign = new RightAssignAccessor();
                }
                return _rightAssign;
            }
        }
    }
}
