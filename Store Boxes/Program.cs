namespace Store_Boxes
{

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            ID = serialNumber;
            Item = item;
            QuantityItem = itemQuantity;
            BoxPrice = item.Price * itemQuantity;
        }
        public string ID { get; set; }
        public Item Item { get; set; }
        public int QuantityItem { get; set; }
        public decimal BoxPrice { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string[] data = command.Split();
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item currentItem = new Item(itemName, itemPrice);
                Box currentBox = new Box(serialNumber, currentItem, itemQuantity);

                boxes.Add(currentBox);

                command = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(box => box.BoxPrice).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.ID}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.QuantityItem}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
        }
    }
}
