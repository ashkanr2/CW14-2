using CW14_1.Models;
using CW14_1.Models.ViewModels;

namespace CW14_1.DAL
{
    public static class Repository
    {
        public static List<DataGet> Informations = new();
        public static bool CheckCapcha(CompleteOrderViewModel model, int generalcapchaCode)
        {

            if (model.CapchaCode == generalcapchaCode.ToString())
                return true;
            return false;
        }
    }
}
