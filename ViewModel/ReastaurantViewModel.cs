using Domain;
using Services.Abstract;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ViewModel
{
    public class ReastaurantViewModel : INotifyPropertyChanged
    {
        private readonly IDishService dserv;
        private readonly IOrderService oserv;
        private readonly IRestaurantService rserv;
        public ICommand AddDishCommand { get; private set; }
        public ICommand AddOrderCommand { get; private set; }

        private Restaurant selectedRest;
        public ObservableCollection<Restaurant> restaurants { get; set; }
        public Restaurant SelectedRest
        {
            get { return selectedRest; }
            set
            {
                selectedRest = value;
                selectedDish = null;
                selectedDishes = null;
                Order = new Order();
                Ordered = new ObservableCollection<Dish>();
                SelectedMenues = new ObservableCollection<Menu>(selectedRest.menus);
                OnPropertyChanged("selectedRest");
            }
        }
        private ObservableCollection<Menu> selectedMenues;
        public ObservableCollection<Menu> SelectedMenues
        {
            get { return selectedMenues; }
            set
            {
                selectedMenues = new ObservableCollection<Menu>(selectedRest.menus);
                OnPropertyChanged("selectedMenues");
            }
        }

        private Menu selectedMenu;
        public Menu SelectedMenu
        {
            get { return selectedMenu; }
            set
            {
                selectedMenu = value;
                if (selectedMenu != null)
                {
                    SelectedDishes = new ObservableCollection<Dish>(selectedMenu.dishes);
                }
                OnPropertyChanged("selectedMenu");
            }
        }

        private ObservableCollection<Dish> selectedDishes;
        public ObservableCollection<Dish> SelectedDishes
        {
            get { return selectedDishes; }
            set
            {
                selectedDishes = new ObservableCollection<Dish>(SelectedMenu.dishes);
                OnPropertyChanged("selectedDishes");
            }
        }

        private Dish selectedDish;
        public Dish SelectedDish
        {
            get { return selectedDish; }
            set
            {
                selectedDish = value;
                OnPropertyChanged("selectedDish");
            }
        }

        private Order order;
        public Order Order
        {
            get { return order; }
            set
            {
                order = value;
                OnPropertyChanged("order");
            }
        }

        public ObservableCollection<Dish> ordered { get; set; }

        public ObservableCollection<Dish> Ordered
        {
            get { return ordered; }
            set
            {
                ordered = new ObservableCollection<Dish>(Order.dishes);
                OnPropertyChanged("ordered");
            }
        }

        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                
                OnPropertyChanged("text");
            }
        }



        public ReastaurantViewModel(IRestaurantService rserv, 
                                    IOrderService oserv, 
                                    IDishService dserv)
        {
            this.dserv = dserv;
            this.oserv = oserv;
            this.rserv = rserv;
            this.order = new Order();
            ordered = new ObservableCollection<Dish>(order.dishes);
            restaurants = new ObservableCollection<Restaurant>(rserv.GetAll());

            AddDishCommand = new Command(obj => AddDishToOrder(),
                                         obj => AddDishToOrderCanExecute());
            AddOrderCommand = new Command(obj => AddOrder(),
                                         obj => AddOrderCanExecute());
        }

        private void AddDishToOrder()
        {
            if (selectedDish != null)
            {
                Order.dishes.Add(selectedDish);
                Ordered = new ObservableCollection<Dish>(order.dishes);
            }
        }

        private bool AddDishToOrderCanExecute()
        {
            if (selectedDish != null)
            {
                return dserv.CheckByProducts(selectedDish) & dserv.CheckByTime(selectedDish);
            }
            return false;
        }

        private void AddOrder()
        {
            oserv.Add(Order);
            Order = new Order();
            Ordered = new ObservableCollection<Dish>();

        }

        private bool AddOrderCanExecute()
        {
            return Order.dishes.Count > 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
