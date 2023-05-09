using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeedbackManager : IFeedbackService
    {
        private readonly IFeedbackDal _feedbackDal;

        public FeedbackManager(IFeedbackDal feedbackDal)
        {
            _feedbackDal = feedbackDal;
        }

        public void TDelete(Feedback t)
        {
            _feedbackDal.Delete(t);
        }

        public Feedback TGetByID(int id)
        {
            return _feedbackDal.GetByID(id);
        }

        public List<Feedback> TGetList()
        {
            return _feedbackDal.GetList();
        }

        public void TInsert(Feedback t)
        {
            _feedbackDal.Insert(t);
        }

        public void TUpdate(Feedback t)
        {
            _feedbackDal.Update(t);
        }
    }
}
