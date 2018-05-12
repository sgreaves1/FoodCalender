using FoodCalender.Model;
using System.Collections.ObjectModel;

namespace FoodCalender.ViewModel
{
    public class MainWindowViewModel
    {
        private ObservableCollection<MealCardModel> _mealCards;

        public MainWindowViewModel()
        {
            MealCards = new ObservableCollection<MealCardModel>();

            AddMeals();
        }

        public void AddMeals()
        {
            for (int i = 0; i < 30; i++)
            {
                MealCards.Add(new MealCardModel() { Name = "N/A" });
            }

            MealCards.Add(new MealCardModel() { Name = "2 Eggs, spinich, tomato, avacado" });
            MealCards.Add(new MealCardModel() { Name = "6 Brazil Nuts" });

        }

        public ObservableCollection<MealCardModel> MealCards
        {
            get { return _mealCards; }
            set { _mealCards = value; }
        }
    }
    
}
