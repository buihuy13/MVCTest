using System.Text;

namespace MVCTest.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string ShowInfor()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(Id + Name + Price);
            return stringBuilder.ToString();
        }
    }
}
