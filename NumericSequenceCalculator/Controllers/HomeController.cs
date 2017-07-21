using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using NumericSequenceCalculator.Helpers;
using NumericSequenceCalculator.Models;

namespace NumericSequenceCalculator.Controllers
{
    public class HomeController : Controller
    {
        #region Actions

        public ActionResult Index()
        {
            return View(InitSequenceCalculatorModel());
        }


        [HttpPost]
        public async Task<ActionResult> Index(SequenceCalculatorModel model)
        {
            var inputValue = model.InputValue;
            var returnModel = await GetSequenceCalculatorModel(inputValue);
            return View(returnModel);
        }
        #endregion

        #region Private Methods

        private SequenceCalculatorModel InitSequenceCalculatorModel()
        {
            return new SequenceCalculatorModel();
        }

        private async  Task<SequenceCalculatorModel> GetSequenceCalculatorModel(int inputValue = 0)
        {
            var model = InitSequenceCalculatorModel();
            var evenSequence = string.Empty;
            var oddSequence = SequenceCalculator.GetOddEvenSequence(inputValue, out evenSequence);
            model.Sequence = SequenceCalculator.GetSequence(inputValue);
            model.OddNumberSequence = oddSequence;
            model.EvenNumberSequence = evenSequence;
            model.CEZSequence = SequenceCalculator.GetCEZSequence(inputValue);
            model.FibonacciSequence = SequenceCalculator.GetFibonaciSeries(inputValue);
            return model;
        }

        #endregion
    }
}