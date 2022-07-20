namespace Milestone
{
    public partial class Form1 : Form
    {
        //ENRIQUE SANCHEZMURILLO CST-150 MILESTONE
        class inventoryItem
        {
            public string name;
            public string description;
            public decimal price;
            public int quantity;
            public String stock;
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void PlayStation()
        {
            inventoryItem playStation = new inventoryItem();
            playStation.name = "Playstation 5";
            playStation.description = "Video Game Console";
            playStation.price = 500;
            playStation.quantity = 3;
            if (playStation.quantity != 0 && playStation.quantity > 0)
            {
                if (playStation.quantity < 5)
                {
                    playStation.stock = "Limited Stock: " + playStation.quantity + " left";
                }
                else
                {
                    playStation.stock = playStation.quantity + " In Stock";
                }
            }
            else
            {
                playStation.stock = "Out of Stock";
            }         
            ViewPlaystationInventory(playStation);
        }
        private void ViewPlaystationInventory(inventoryItem item)
        {
            MessageBox.Show(item.name + "\n" + item.description + "\n" + item.price.ToString("c") + "\n" + item.stock);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PlayStation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}