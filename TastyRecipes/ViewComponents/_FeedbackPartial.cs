using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TastyRecipes.ViewComponents
{
    public class _FeedbackPartial:ViewComponent
    {
        private readonly IFeedbackService _feedbackService;

        public _FeedbackPartial(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public IViewComponentResult Invoke()
        {
            var values= _feedbackService.TGetList();
            return View(values);
        }
    }
}
