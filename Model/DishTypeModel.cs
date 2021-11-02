namespace Model
{
    public class DishTypeModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public DishTypeModel(string name)
        {
            this.name = name;
        }
    }
}
